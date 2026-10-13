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
            listViewProducts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            pictureBoxImageProduct = new PictureBox();
            labelCost = new Label();
            labelAddress = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProduct).BeginInit();
            SuspendLayout();
            // 
            // listViewProducts
            // 
            listViewProducts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewProducts.Dock = DockStyle.Left;
            listViewProducts.FullRowSelect = true;
            listViewProducts.Location = new Point(0, 0);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(419, 450);
            listViewProducts.TabIndex = 0;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            listViewProducts.View = View.Details;
            listViewProducts.SelectedIndexChanged += listViewProducts_SelectedIndexChanged;
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
            // pictureBoxImageProduct
            // 
            pictureBoxImageProduct.Location = new Point(425, 0);
            pictureBoxImageProduct.Name = "pictureBoxImageProduct";
            pictureBoxImageProduct.Size = new Size(152, 198);
            pictureBoxImageProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImageProduct.TabIndex = 2;
            pictureBoxImageProduct.TabStop = false;
            // 
            // labelCost
            // 
            labelCost.AutoSize = true;
            labelCost.Location = new Point(429, 223);
            labelCost.Name = "labelCost";
            labelCost.Size = new Size(0, 15);
            labelCost.TabIndex = 3;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(466, 364);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(38, 15);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "label1";
            // 
            // FormShop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelAddress);
            Controls.Add(labelCost);
            Controls.Add(pictureBoxImageProduct);
            Controls.Add(listViewProducts);
            Name = "FormShop";
            Text = "Интернет магазин \"Букинист\"";
            Load += FormShop_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImageProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewProducts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private PictureBox pictureBoxImageProduct;
        private Label labelCost;
        private Label labelAddress;
    }
}
