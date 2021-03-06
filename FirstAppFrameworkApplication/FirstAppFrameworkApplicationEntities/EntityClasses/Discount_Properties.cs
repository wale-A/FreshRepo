//DO NOT MODIFY THIS FILE
//Instead, override the this[] indexer in your entity base class
using System;
using AppFramework.AppClasses;
namespace FirstAppFrameworkApplicationEntities.EntityClasses
{
    partial class Discount
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "Discount", Order = 0)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Discount")]
        [System.ComponentModel.DataAnnotations.Editable(false, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String DiscountID
        {
            get
            {
                return this.getString("DiscountID");
            }
            set
            {
                this["DiscountID"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Short Description", Order = 1)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Short Description")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual String Description
        {
            get
            {
                return this.getString("Description");
            }
            set
            {
                this["Description"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "DiscountType", Order = 2)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in DiscountType")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual FirstAppFrameworkApplicationEntities.EntityEnums.DeductionType DiscountType
        {
            get
            {
                return (FirstAppFrameworkApplicationEntities.EntityEnums.DeductionType)this.getEnum("DiscountType");
            }
            set
            {
                this["DiscountType"] = value;
            }
        }

        [System.ComponentModel.DataAnnotations.Display(Name = "Value", Order = 3)]
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Please fill in Value")]
        [System.ComponentModel.DataAnnotations.Editable(true, AllowInitialValue = true)]
        [AppFramework.AppClasses.Autogenerated]
        public virtual decimal Value
        {
            get
            {
                return this.getReal("Value");
            }
            set
            {
                this["Value"] = value;
            }
        }

    }
}
