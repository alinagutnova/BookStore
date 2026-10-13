using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class DiscountProduct: Product
    {
        public float Discount { get; set; }

        public DiscountProduct(string name, string description, decimal price,
                                string imagePath, float discount) :
            base(name, description, price, imagePath)
        {
            Discount = discount;
            Type = ProductType.Discount;
        }

        public override decimal GetPrice()
        {
            double price = Convert.ToDouble(Price);
            return Convert.ToDecimal(Math.Truncate(price-price*Discount/100));
        }
    }
}
