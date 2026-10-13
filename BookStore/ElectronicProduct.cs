using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class ElectronicProduct : Product
    {
        public string URL { get; set; }

        public ElectronicProduct(string name, string description, decimal price,
                                string imagePath, string url) :
            base(name, description, price, imagePath)
        {
            URL = url;
            Type = ProductType.Electronic;
        }

        public override decimal GetPrice()
        {
            return Price;
        }
    }
}
