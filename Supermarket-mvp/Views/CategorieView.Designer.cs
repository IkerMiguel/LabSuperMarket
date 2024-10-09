namespace Supermarket_mvp.Views
{
    partial class CategorieView
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
            tabPageCategorieList = new TabPage();
            DgCategorie = new DataGridView();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            BtnSearch = new Button();
            label3 = new Label();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCategorieDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label6 = new Label();
            TxtCategorieDescription = new TextBox();
            TxtCategorieName = new TextBox();
            label5 = new Label();
            TxtCategorieId = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCategorieList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).BeginInit();
            tabPageCategorieDetail.SuspendLayout();
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
            label1.Size = new Size(220, 59);
            label1.TabIndex = 1;
            label1.Text = "Categorie";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sell;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCategorieList);
            tabControl1.Controls.Add(tabPageCategorieDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 122);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 328);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCategorieList
            // 
            tabPageCategorieList.Controls.Add(DgCategorie);
            tabPageCategorieList.Controls.Add(BtnClose);
            tabPageCategorieList.Controls.Add(BtnDelete);
            tabPageCategorieList.Controls.Add(BtnEdit);
            tabPageCategorieList.Controls.Add(BtnNew);
            tabPageCategorieList.Controls.Add(BtnSearch);
            tabPageCategorieList.Controls.Add(label3);
            tabPageCategorieList.Controls.Add(TxtSearch);
            tabPageCategorieList.Controls.Add(label2);
            tabPageCategorieList.Location = new Point(4, 24);
            tabPageCategorieList.Name = "tabPageCategorieList";
            tabPageCategorieList.Padding = new Padding(3);
            tabPageCategorieList.Size = new Size(792, 300);
            tabPageCategorieList.TabIndex = 0;
            tabPageCategorieList.Text = "Categorie List";
            tabPageCategorieList.UseVisualStyleBackColor = true;
            // 
            // DgCategorie
            // 
            DgCategorie.AllowUserToAddRows = false;
            DgCategorie.AllowUserToDeleteRows = false;
            DgCategorie.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCategorie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCategorie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCategorie.Location = new Point(12, 74);
            DgCategorie.Name = "DgCategorie";
            DgCategorie.ReadOnly = true;
            DgCategorie.Size = new Size(606, 218);
            DgCategorie.TabIndex = 8;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(626, 242);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(160, 50);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(626, 186);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(160, 50);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(626, 130);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(160, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(626, 74);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(160, 50);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(568, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 50);
            BtnSearch.TabIndex = 3;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(12, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(539, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Search categorie";
            // 
            // tabPageCategorieDetail
            // 
            tabPageCategorieDetail.Controls.Add(BtnCancel);
            tabPageCategorieDetail.Controls.Add(BtnSave);
            tabPageCategorieDetail.Controls.Add(label6);
            tabPageCategorieDetail.Controls.Add(TxtCategorieDescription);
            tabPageCategorieDetail.Controls.Add(TxtCategorieName);
            tabPageCategorieDetail.Controls.Add(label5);
            tabPageCategorieDetail.Controls.Add(TxtCategorieId);
            tabPageCategorieDetail.Controls.Add(label4);
            tabPageCategorieDetail.Location = new Point(4, 24);
            tabPageCategorieDetail.Name = "tabPageCategorieDetail";
            tabPageCategorieDetail.Padding = new Padding(3);
            tabPageCategorieDetail.Size = new Size(792, 300);
            tabPageCategorieDetail.TabIndex = 1;
            tabPageCategorieDetail.Text = "Categorie Detail";
            tabPageCategorieDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(129, 196);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 50);
            BtnCancel.TabIndex = 8;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(28, 196);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 50);
            BtnSave.TabIndex = 7;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 130);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Description";
            // 
            // TxtCategorieDescription
            // 
            TxtCategorieDescription.Location = new Point(12, 148);
            TxtCategorieDescription.Name = "TxtCategorieDescription";
            TxtCategorieDescription.Size = new Size(236, 23);
            TxtCategorieDescription.TabIndex = 4;
            // 
            // TxtCategorieName
            // 
            TxtCategorieName.Location = new Point(12, 87);
            TxtCategorieName.Name = "TxtCategorieName";
            TxtCategorieName.Size = new Size(236, 23);
            TxtCategorieName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 69);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 2;
            label5.Text = "Categorie name";
            // 
            // TxtCategorieId
            // 
            TxtCategorieId.Location = new Point(12, 30);
            TxtCategorieId.Name = "TxtCategorieId";
            TxtCategorieId.ReadOnly = true;
            TxtCategorieId.Size = new Size(236, 23);
            TxtCategorieId.TabIndex = 1;
            TxtCategorieId.Text = "0";
            TxtCategorieId.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 12);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 0;
            label4.Text = "Categorie Id";
            // 
            // CategorieView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CategorieView";
            Text = "CategorieView";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCategorieList.ResumeLayout(false);
            tabPageCategorieList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCategorie).EndInit();
            tabPageCategorieDetail.ResumeLayout(false);
            tabPageCategorieDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCategorieList;
        private TabPage tabPageCategorieDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private Button BtnSearch;
        private Label label3;
        private TextBox TxtSearch;
        private Label label2;
        private DataGridView DgCategorie;
        private Label label6;
        private TextBox TxtCategorieDescription;
        private TextBox TxtCategorieName;
        private Label label5;
        private TextBox TxtCategorieId;
        private Label label4;
        private Button BtnSave;
        private Button BtnCancel;
    }
}