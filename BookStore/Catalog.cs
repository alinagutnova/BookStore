using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Catalog
    {
        public List<Product> Products { get; set; }

        public Catalog(string filename) {
            Products = new List<Product>();
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            { 
                string s = reader.ReadLine();
                string[] ss = s.Split("|");
                Product p = new PhysicalProduct(ss[0], ss[1], Convert.ToDecimal(ss[2]), ss[3], 100);
                Products.Add(p);
            }
            reader.Close();
        }

        public Product? GetById(int id)
        {
            foreach (var item in Products)
            { 
                if (item.Id == id) return item;
            }
            return null;
        }
    }
}
