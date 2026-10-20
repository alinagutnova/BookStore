namespace BookStore
{
    partial class FormCart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
            dataGridViewCart = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewButtonColumn();
            Column7 = new DataGridViewButtonColumn();
            Column8 = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCart
            // 
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridViewCart.Dock = DockStyle.Top;
            dataGridViewCart.Location = new Point(0, 0);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCart.RowHeadersVisible = false;
            dataGridViewCart.Size = new Size(554, 311);
            dataGridViewCart.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Width = 30;
            // 
            // Column2
            // 
            Column2.HeaderText = "Название";
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "Цена";
            Column3.Name = "Column3";
            Column3.Width = 50;
            // 
            // Column4
            // 
            Column4.HeaderText = "Кол-во";
            Column4.Name = "Column4";
            Column4.Width = 50;
            // 
            // Column5
            // 
            Column5.HeaderText = "Стоимость";
            Column5.Name = "Column5";
            Column5.Width = 80;
            // 
            // Column6
            // 
            Column6.HeaderText = "+";
            Column6.Name = "Column6";
            Column6.Width = 30;
            // 
            // Column7
            // 
            Column7.HeaderText = "-";
            Column7.Name = "Column7";
            Column7.Width = 30;
            // 
            // Column8
            // 
            Column8.HeaderText = "";
            Column8.Image = (Image)resources.GetObject("Column8.Image");
            Column8.Name = "Column8";
            Column8.Resizable = DataGridViewTriState.True;
            Column8.Width = 30;
            // 
            // FormCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 384);
            Controls.Add(dataGridViewCart);
            Name = "FormCart";
            Text = "Корзина";
            Load += FormCart_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewCart;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Column6;
        private DataGridViewButtonColumn Column7;
        private DataGridViewImageColumn Column8;
    }
}