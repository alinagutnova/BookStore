using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum ProductType
    { 
        Physical,
        Electronic,
        Discount
    }

    public abstract class Product
    {
        //Guid Id { get; set; }
        static private int count = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
        public ProductType Type { get; set; }

        public Product(string name, string description, decimal price, string imagePath)
        {
            //Id = Guid.NewGuid();
            Id = ++count;
            Name = name;
            Description = description;
            Price = price;
            ImagePath = imagePath;
            Type = ProductType.Physical;
        }

        public abstract decimal GetPrice();
    }
}

