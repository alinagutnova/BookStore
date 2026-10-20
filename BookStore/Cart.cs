using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Cart
    {
        public User User { get; set; }
        private List<CartItem> Items { get; set; }
        public decimal Amount { get; set; }
        
        public Cart(User user) 
        {
            User = user;
            Items = new List<CartItem>();
            Amount = 0;
        }

        public void Add(Product product)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Product == product)
                {
                    Items[i].Quantity++;
                    return;
                }
            }
            Items.Add(new CartItem(product,1));
        }

        public void Remove(Product product)
        {
            for (int i=0;i<Items.Count;i++)
            {
                if (Items[i].Product == product)
                {
                    Items.RemoveAt(i);
                }
            }
        }

        public List<CartItem> GetItems()
        { 
            return Items;
        }
    }
}
