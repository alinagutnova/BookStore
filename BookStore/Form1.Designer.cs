namespace BookStore
{
    partial class FormShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            labelCost = new Label();
            pictureBoxImageProduct = new PictureBox();
            buttonAddCart = new Button();
            pictureBoxShowCart = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowCart).BeginInit();
            SuspendLayout();
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewProducts.Dock = DockStyle.Left;
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(0, 0);
            listViewProducts.MultiSelect = false;
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(419, 450);
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.MouseClick += listViewProducts_MouseClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Название";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Описание";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Цена";
            columnHeader4.Width = 80;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(429, 223);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(0, 15);
            labelCost.TabIndex = 3;
            // 
            // pictureBoxImageProduct
            // 
            pictureBoxImageProduct.Location = new Point(425, 0);
            pictureBoxImageProduct.Name = "pictureBoxImageProduct";
            pictureBoxImageProduct.Size = new Size(152, 198);
            pictureBoxImageProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageProduct.TabIndex = 2;
            pictureBoxImageProduct.TabStop = false;
            // 
            // buttonAddCart
            // 
            buttonAddCart.Location = new Point(429, 395);
            buttonAddCart.Name = "buttonAddCart";
            buttonAddCart.Size = new Size(154, 23);
            buttonAddCart.TabIndex = 4;
            buttonAddCart.Text = "Добавить в корзину";
            buttonAddCart.UseVisualStyleBackColor = true;
            buttonAddCart.Click += buttonAddCart_Click;
            // 
            // pictureBoxShowCart
            // 
            pictureBoxShowCart.Image = (Image)resources.GetObject("pictureBoxShowCart.Image");
            pictureBoxShowCart.Location = new Point(615, 0);
            pictureBoxShowCart.Name = "pictureBoxShowCart";
            pictureBoxShowCart.Size = new Size(41, 37);
            pictureBoxShowCart.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShowCart.TabIndex = 5;
            pictureBoxShowCart.TabStop = false;
            pictureBoxShowCart.Click += pictureBoxShowCart_Click;
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxShowCart);
            Controls.Add(buttonAddCart);
            Controls.Add(labelCost);
            Controls.Add(pictureBoxImageProduct);
            Controls.Add(listViewProducts);
            Name = "FormShop";
            Text = "Интернет магазин \"Букинист\"";
            Load += FormShop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label labelCost;
        private PictureBox pictureBoxImageProduct;
        private Button buttonAddCart;
        private PictureBox pictureBoxShowCart;
    }
}
