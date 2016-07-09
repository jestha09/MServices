using System;
using System.ComponentModel.DataAnnotations;
using Interfaces;

namespace ProductCatalogue.Models
{

    public interface IProduct
    {
        string ProductCode { get; set; }
        string ProductName { get; set; }
        decimal ProductAmount { get; set; }
        decimal ProductDiscount { get; }
        DateTime SalesDate { get; set; }
        string ProductType { get; }
    }

    public class Product: IProduct
    {
        private IValidation<IProduct> _validation = null;
        public Product(IValidation<IProduct> objValidation)
        {
            _validation = objValidation;
        }

        [Required]
        [RegularExpression("^[A-Z]{3,3}[0-9]{4,4}$")]
        [Key]
        public string ProductCode { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductName { get; set; }

        private decimal _ProductAmount;
        public virtual decimal ProductAmount
        {
            get { return _ProductAmount; }
            set
            {
                _ProductAmount = value;
            }
        }

        protected decimal _ProductDiscount = 0;
        public decimal ProductDiscount
        {

            get
            {
                return _ProductDiscount;
            }
        }
        
        public DateTime SalesDate { get; set; }
        
        protected string _ProductType = "S";
        public string ProductType
        {
            get
            {
                return _ProductType;
            }
        }
    }
}
