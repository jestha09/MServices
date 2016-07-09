using Interfaces;

namespace ProductCatalogue.Models
{
    public class Activity : Product
    {
        public Activity(IValidation<IProduct> objValidation) : base(objValidation)
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
                if (this.ProductAmount > 1000)
                {
                    this._ProductDiscount = 15;
                    this._ProductType = "E";
                }
                base.ProductAmount = value;
            }
        }
    }
}
