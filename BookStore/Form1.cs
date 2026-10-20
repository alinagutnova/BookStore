namespace BookStore
{
    public partial class FormShop : Form
    {
        Catalog catalog;
        User user;
        Cart cart;

        public FormShop()
        {
            InitializeComponent();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            user = new User("Алина", "agutnova@yandex.ru", "123456");
            Text = "Интернет магазин \"Букинист\" - " + user.Name;

            cart = new Cart(user);

            catalog = new Catalog("warehouse.csv");
            ListViewItem[] items = new ListViewItem[catalog.Count];
            for (int i = 0; i < catalog.Count; i++)
            {
                var item = catalog[i];
                ListViewItem list_item = new ListViewItem(item.Id.ToString());
                list_item.SubItems.Add(item.Name);
                list_item.SubItems.Add(item.Description);
                list_item.SubItems.Add(item.Price.ToString());
                items[i] = list_item;
            }
            listViewProducts.Items.AddRange(items);
        }

        private void listViewProducts_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewProducts.GetItemAt(e.X, e.Y);
            if (item == null) return;
            Product product = catalog.GetById(int.Parse(item.SubItems[0].Text));
            if (product == null) return;
            pictureBoxImageProduct.ImageLocation = product.ImagePath;
            labelCost.Text = product.GetPrice().ToString();
            if (product.Type == ProductType.Physical)
            {
                PhysicalProduct p = (PhysicalProduct)product;
            }
        }

        private void buttonAddCart_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите товар");
                return;
            }
            Product product = catalog.GetById(int.Parse(listViewProducts.SelectedItems[0].Text));
            cart.Add(product);
        }

        private void pictureBoxShowCart_Click(object sender, EventArgs e)
        {
            Form form = new FormCart(cart);
            form.ShowDialog();
        }
    }
}
