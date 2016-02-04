//DO NOT MODIFY THIS FILE
//Instead, override the this[] indexer in your entity base class
using System;
using AppFramework.AppClasses;
namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class OrderMiscCharges
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Order ID", Order = 0)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Order ID")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String OrderID
        {
            get
            {
                return this.getString("OrderID");
            }
            set
            {
                this["OrderID"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Amount", Order = 1)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Amount")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = false)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual decimal Amount
        {
            get
            {
                return this.getReal("Amount");
            }
            set
            {
                this["Amount"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Charge ID", Order = 2)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Charge ID")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String MiscChargeID
        {
            get
            {
                return this.getString("MiscChargeID");
            }
            set
            {
                this["MiscChargeID"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Item", Order = 3)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Item")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String ItemID
        {
            get
            {
                return this.getString("ItemID");
            }
            set
            {
                this["ItemID"] = value;
            }
        }

    }
}
