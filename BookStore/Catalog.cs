using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookStore
{
    public class Catalog : IEnumerable<Product>
    {
        private List<Product> products { get; set; }
        public int Count = 0;

        public Catalog(string filename) {
            products = new List<Product>();
            StreamReader reader = new StreamReader(filename);
            while (!reader.EndOfStream)
            {
                string? s = reader.ReadLine();
                if (string.IsNullOrWhiteSpace(s)) continue; 

                string[] ss = s.Split('|');

                switch (ss[0])
                {
                    case "e":
                        products.Add(new ElectronicProduct(ss[1], ss[2],
                            decimal.Parse(ss[3], CultureInfo.InvariantCulture), ss[4], ss[5]));
                        break;
                    case "d":
                        products.Add(new DiscountProduct(ss[1], ss[2],
                            decimal.Parse(ss[3], CultureInfo.InvariantCulture), ss[4],
                            float.Parse(ss[5], CultureInfo.InvariantCulture)));
                        break;
                    default:
                        products.Add(new PhysicalProduct(ss[1], ss[2],
                            decimal.Parse(ss[3], CultureInfo.InvariantCulture), ss[4],
                            decimal.Parse(ss[5], CultureInfo.InvariantCulture)));
                        break;
                }
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
        public IEnumerator<Product> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
