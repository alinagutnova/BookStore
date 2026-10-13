using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class PhysicalProduct : Product
    {
        public decimal DeliveryCost { get; set; }
        private string Address { get; set; }

        public PhysicalProduct(string name, string description, decimal price, 
                                string imagePath, decimal deliveryCost):
            base(name, description, price, imagePath)
        {
            DeliveryCost = deliveryCost;
        }

        public override decimal GetPrice()
        {
            return Price + DeliveryCost;              
        }

        public string GetAddress()
        {
            return Address;
        }

        public void SetAddress(string address)
        { 
            Address = address;
        }
    }
}
