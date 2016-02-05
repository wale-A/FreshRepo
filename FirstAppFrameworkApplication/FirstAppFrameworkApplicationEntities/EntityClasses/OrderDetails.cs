using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using FirstAppFrameworkApplicationEntities.EntityEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class OrderDetails : EntityBase
    {
        protected override string Caption
        {
            get { return "Order Details"; }
        }

        protected override Type FormType
        {
            get { return typeof(Forms.Orders); }
        }

        protected override Type ListFormType
        {
            get { return typeof(Forms.Orders); }
        }

        public override string TableName
        {
            get { return "orderdetails"; }
        }

        protected override string TitleColumn1
        {
            get { return "OrderID"; }
        }

        protected override string TitleColumn2
        {
            get { return "ItemID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["OrderID"] = new FieldInfo(false, false, true, new OrderEDT());
            FieldInfoList["ItemCategoryID"] = new FieldInfo(true, false, true, new ItemCategoryEDT());
            FieldInfoList["ItemID"] = new FieldInfo(true, false, true, new ItemEDT());
            FieldInfoList["Quantity"] = new FieldInfo(true, false, true, "Quantity", new IntEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, "Amount", new AmountEDT());

            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");
            TableInfo.KeyInfoList["ItemCategoryID"] = new KeyInfo(KeyType.Key, "ItemCategoryID");
            TableInfo.KeyInfoList["ItemID_FK"] = new KeyInfo(KeyType.Key, "ItemID");
            TableInfo.KeyInfoList["CompositeKey"] = new KeyInfo(KeyType.Unique, "OrderID", "ItemCategoryID", "ItemID");
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            
            var item = (from i in new QueryableEntity<Items>()
                             where i.ItemID == this.ItemID
                             select i).AppFirst();
            if (this.Quantity <= item.ItemQuantity)
            {
                item.ItemQuantity -= this.Quantity;
                this.Amount = item.Price * this.Quantity;
                var order = (from o in new QueryableEntity<Order>()
                             where o.OrderID == this.OrderID
                             select o).AppFirst();
                order.Amount -= this.Amount;
                order.TempMoney = this.Amount;
                order.update();
                item.update();
                                
                computeMiscChargesForItem();
                return base.insert(forceWrite, callSaveMethod);
            }
            else
                throw new Exception("quantity in order exceed maximum item quantity:  " + item.ItemQuantity);
        }

        private void computeMiscChargesForItem()
        {
            var deduction = (from d in new QueryableEntity<MiscCharge>()
                             where d.Default == true
                             orderby d.ChargeOrder
                             select d).ToList();
            MiscCharge tempD = null;
            foreach (var d in deduction)
            {
                if (tempD == null)
                    tempD = d;
                if (tempD.ChargeOrder == d.ChargeOrder)
                    TempValue = Amount;
                else if (tempD.ChargeOrder <= d.ChargeOrder)
                {
                    tempD = d;
                    TempValue = Amount + ExtraCharge;
                }

                if (d.DeductionType == DeductionType.Fixed)
                    ExtraCharge = d.Value;
                else if (d.DeductionType == DeductionType.Percentage)
                    ExtraCharge = (TempValue * d.Value) / 100;

                var orderMiscCharge = (from o in new QueryableEntity<OrderMiscCharges>()
                                       where o.OrderID == this.OrderID && o.MiscChargeID == d.DeductionID
                                       select o).AppFirst();
                if (orderMiscCharge == null)
                {
                   orderMiscCharge = new OrderMiscCharges
                    {
                        OrderID = this.OrderID,
                        Amount = ExtraCharge,
                        MiscChargeID = d.DeductionID,
                        ItemID = this.ItemID
                    };
                   orderMiscCharge.insert();
                }                
                else
                {
                    orderMiscCharge.Amount += ExtraCharge;
                    orderMiscCharge.TempMoney = ExtraCharge;
                    orderMiscCharge.update();
                }
            }
        }

        public decimal TempValue { get; set; }
        public decimal ExtraCharge { get; set; }

        public override long delete(bool forceWrite)
        {            
            //var category = (from itemCategory in new QueryableEntity<ItemCategory>() where itemCategory.ItemCategoryID == this.ItemCategoryID select itemCategory).AppFirst();
            //var itemQuantity = (from i in new QueryableEntity<Items>() where i.ItemID == this.ItemID select i.ItemQuantity).ToList();
            //category.ItemQuantity += this.Quantity;
            //category.update();
            var item = (from i in new QueryableEntity<Items>()
                        where i.ItemID == this.ItemID
                        select i).AppFirst();
            item.ItemQuantity += this.Quantity;
            item.update();

            removeMiscChargesForItem();
            return base.delete(forceWrite);
        }

        private void removeMiscChargesForItem()
        {           
            var deduction = (from d in new QueryableEntity<MiscCharge>()
                             where d.Default == true
                             orderby d.ChargeOrder
                             select d).ToList();
            
            MiscCharge tempD = new MiscCharge();
            foreach (var d in deduction)
            {
                if (tempD == null)
                    tempD = d;
                if (tempD.ChargeOrder == d.ChargeOrder)
                    TempValue = Amount;
                else if (tempD.ChargeOrder <= d.ChargeOrder)
                {
                    tempD = d;
                    TempValue = Amount + ExtraCharge;
                }

                if (d.DeductionType == DeductionType.Fixed)
                    ExtraCharge = d.Value;
                else if (d.DeductionType == DeductionType.Percentage)
                    ExtraCharge = (TempValue * d.Value) / 100;

                var orderMiscCharge = (from o in new QueryableEntity<OrderMiscCharges>()
                                       where o.OrderID == this.OrderID && o.MiscChargeID == d.DeductionID
                                       select o).AppFirst();
                orderMiscCharge.Amount -= ExtraCharge;
                orderMiscCharge.TempMoney = -ExtraCharge;
                orderMiscCharge.update();
            }
        }
         
    }
}