using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class FormCart : Form
    {
        Cart cart;

        public FormCart(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void FormCart_Load(object sender, EventArgs e)
        {
            if (cart != null)
            {
                foreach (var Items in cart.GetItems())
                {
                    dataGridViewCart.Rows.Add(Items.Product.Id,
                                        Items.Product.Name,
                                        Items.Product.GetPrice(),
                                        Items.Quantity,
                                        Items.Product.GetPrice()*Items.Quantity);
                }
            }
        }
    }
}
