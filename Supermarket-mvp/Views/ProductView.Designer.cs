namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            label2 = new Label();
            DgProducts = new DataGridView();
            TxtSearch = new TextBox();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            tabPageProductDetail = new TabPage();
            ComboBoxProductCategory = new ComboBox();
            TxtProductStock = new TextBox();
            TxtProductPrice = new TextBox();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            BtnCancel = new Button();
            BtnSave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 122);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            label1.Location = new Point(133, 30);
            label1.Name = "label1";
            label1.Size = new Size(204, 59);
            label1.TabIndex = 2;
            label1.Text = "Products";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 122);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 328);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Controls.Add(DgProducts);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 300);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product list";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 11);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 15;
            label2.Text = "Product Id";
            // 
            // DgProducts
            // 
            DgProducts.AllowUserToAddRows = false;
            DgProducts.AllowUserToDeleteRows = false;
            DgProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProducts.Location = new Point(20, 70);
            DgProducts.Name = "DgProducts";
            DgProducts.ReadOnly = true;
            DgProducts.Size = new Size(602, 218);
            DgProducts.TabIndex = 14;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(20, 29);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(539, 23);
            TxtSearch.TabIndex = 13;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(626, 238);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(160, 50);
            BtnClose.TabIndex = 12;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(626, 182);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(160, 50);
            BtnDelete.TabIndex = 11;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(626, 126);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(160, 50);
            BtnEdit.TabIndex = 10;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(626, 70);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(160, 50);
            BtnNew.TabIndex = 9;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(572, 14);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 50);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(ComboBoxProductCategory);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(label7);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 300);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // ComboBoxProductCategory
            // 
            ComboBoxProductCategory.FormattingEnabled = true;
            ComboBoxProductCategory.Location = new Point(295, 75);
            ComboBoxProductCategory.Name = "ComboBoxProductCategory";
            ComboBoxProductCategory.Size = new Size(190, 23);
            ComboBoxProductCategory.TabIndex = 14;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(295, 31);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(190, 23);
            TxtProductStock.TabIndex = 13;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(8, 119);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(166, 23);
            TxtProductPrice.TabIndex = 12;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(8, 75);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(166, 23);
            TxtProductName.TabIndex = 11;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(8, 31);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(166, 23);
            TxtProductId.TabIndex = 10;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(147, 163);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 50);
            BtnCancel.TabIndex = 9;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(33, 163);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 50);
            BtnSave.TabIndex = 8;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(295, 57);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 4;
            label7.Text = "Product category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 13);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 3;
            label6.Text = "Product stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 101);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 2;
            label5.Text = "Product price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 57);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 1;
            label4.Text = "Product name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 13);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Product id";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "ProductView";
            Load += ProductView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProducts).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private DataGridView DgProducts;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox TxtProductPrice;
        private TextBox TxtProductName;
        private TextBox TxtProductId;
        private Button BtnCancel;
        private Button BtnSave;
        private ComboBox ComboBoxProductCategory;
        private TextBox TxtProductStock;
    }
}