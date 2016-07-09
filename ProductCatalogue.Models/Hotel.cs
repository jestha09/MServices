using System;
using Interfaces;

namespace ProductCatalogue.Models
{
    public class Hotel : Product
    {
        public Hotel(IValidation<IProduct> objValidation) : base(objValidation)
        {
        }

        public override decimal ProductAmount
        {
            get
            {
                return base.ProductAmount;
            }
            set
            {
                if (this.SalesDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    this._ProductDiscount = 25;
                    this._ProductType = "M";
                }
                base.ProductAmount = value;
            }
        }
    }
}
