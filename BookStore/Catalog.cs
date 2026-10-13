using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Catalog
    {
        private List<Product> products { get; set; }
        public int Count = 0;

        public Catalog(string filename) {
            products = new List<Product>();
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            { 
                string s = reader.ReadLine();
                string[] ss = s.Split("|");
                Product p;
                switch (ss[0])
                {
                    case "e":
                        p = new ElectronicProduct(ss[1], ss[2], Convert.ToDecimal(ss[3]), ss[4], ss[5]);
                        break;
                    case "d":
                        p = new DiscountProduct(ss[1], ss[2], Convert.ToDecimal(ss[3]), ss[4], float.Parse(ss[5]));
                        break;
                    default:
                        p = new PhysicalProduct(ss[1], ss[2], Convert.ToDecimal(ss[3]), ss[4], Convert.ToDecimal(ss[5]));
                        break;
                }
                products.Add(p);
                Count++;
            }
            reader.Close();
        }

        public Product this[int index]
        {
            get { return products[index]; }

            set { products[index] = value; }
        }

        public Product? GetById(int id)
        {
            foreach (var item in products)
            { 
                if (item.Id == id) return item;
            }
            return null;
        }
    }
}
