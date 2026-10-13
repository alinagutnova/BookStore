namespace BookStore
{
    public partial class FormShop : Form
    {
        Catalog catalog;

        public FormShop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            catalog = new Catalog("warehouse.csv");
            ListViewItem[] items = new ListViewItem[catalog.Products.Count];
            int i = 0;
            foreach (var item in catalog.Products)
            {
                ListViewItem list_item = new ListViewItem(item.Id.ToString());
                list_item.SubItems.Add(item.Name);
                list_item.SubItems.Add(item.Description);
                list_item.SubItems.Add(item.Price.ToString());
                items[i++] = list_item;
            }
            listViewProducts.Items.AddRange(items);
        }

        private void listViewProducts_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listViewProducts.GetItemAt(e.X, e.Y);
            if (item == null) return;
            Product product = catalog.GetById(int.Parse(item.SubItems[0].Text));
            if (product==null) return;
            pictureBoxImageProduct.ImageLocation = product.ImagePath;
        }
    }
}
