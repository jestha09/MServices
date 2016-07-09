using System;
using Interfaces;
using ProductCatalogue.Models;

namespace ProductCatalogue.ValidationAlgorithms
{
    public class HotelValidation : IValidation<IProduct>
    {
        public void Validate(IProduct input)
        {
            if (input.ProductAmount==0)
            {
                throw new Exception("Product Amount is required");
            }
        }
    }
}
