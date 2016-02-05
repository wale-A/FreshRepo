using AppFramework.AppClasses;
using AppFramework.AppClasses.EDTs;
using AppFramework.Linq;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.EntityEnums;
using FirstAppFrameworkApplicationEntities.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class OrderMiscCharges : EntityBase
    {
        public decimal TempMoney { get; set; }
        public decimal TempValue { get; set; }
        protected override string Caption
        {
            get { return "Order Deductions"; }
        }

        protected override Type FormType
        {
            get { return typeof(OrderDeductions); }
        }

        protected override Type ListFormType
        {
            get { return typeof(OrderDeductions); }
        }

        public override string TableName
        {
            get { return "orderdeductions"; }
        }

        protected override string TitleColumn1
        {
            get { return "OrderID"; }
        }

        protected override string TitleColumn2
        {
            get { return "DeductionID"; }
        }

        protected override void setupEntityInfo()
        {
            FieldInfoList["OrderID"] = new FieldInfo(true, false, true, new OrderEDT());
            FieldInfoList["Amount"] = new FieldInfo(false, false, true, new AmountEDT());
            FieldInfoList["MiscChargeID"] = new FieldInfo(true, false, true, new MiscChargeEDT());
            FieldInfoList["ItemID"] = new FieldInfo(false, false, false, new ItemEDT());
            
            TableInfo.KeyInfoList["OrderID"] = new KeyInfo(KeyType.Key, "OrderID");
            TableInfo.KeyInfoList["MiscChargeID"] = new KeyInfo(KeyType.Key, "MiscChargeID");
            //TableInfo.KeyInfoList["Amount"] = new KeyInfo(KeyType.Key, "Amount");
            TableInfo.KeyInfoList["PrimaryKey"] = new KeyInfo(KeyType.PrimaryField, "MiscChargeID", "OrderID");

            FieldGroups["grid"] = new String[] { "OrderID", "Amount", "MiscChargeID", "ItemID", "CreatedBy", "CreatedDateTime" };
        }

        protected override long insert(bool forceWrite, bool callSaveMethod)
        {
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            var deduction = (from d in new QueryableEntity<MiscCharge>()
                             where d.DeductionID == MiscChargeID
                             select d).AppFirst();
            if (this.Amount == 0)
            {               
                if (deduction.DeductionType == DeductionType.Fixed)
                    Amount = deduction.Value;
                else if (deduction.DeductionType == DeductionType.Percentage)
                    Amount = -(order.Amount * deduction.Value) / 100;
            }
            
            order.Amount -= this.Amount;
            order.TempMoney = this.Amount;
            order.update();
                        
            return base.insert(forceWrite, callSaveMethod);
        }

        public override long delete(bool forceWrite)
        {
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            order.Amount -= this.Amount;
            order.TempMoney = -this.Amount;
            order.update();

            //var miscCharge = (from m in new QueryableEntity<MiscCharge>()
            //                  where m.DeductionID == this.MiscChargeID
            //                  select m).AppFirst();
            //var totalObj = (from t in new QueryableEntity<Total>()
            //                where t.OrderID == this.OrderID && t.Description == miscCharge.Description
            //                select t).AppFirst();
            //if (totalObj != null)
            //    totalObj.Amount -= this.Amount;

            return base.delete(forceWrite);
        }

        protected override long update(bool forceWrite, bool callSaveMethod)
        {
            var order = (from o in new QueryableEntity<Order>()
                         where o.OrderID == this.OrderID
                         select o).AppFirst();
            order.Amount -= TempMoney;
            order.TempMoney = TempMoney;
            order.update();
            return base.update(forceWrite, callSaveMethod);
        }
    }
}