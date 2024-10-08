namespace Supermarket_mvp.Views
{
    partial class CustomerView
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
            tabPageCustomerList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgCustomer = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageCustomerDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtCustomerEmail = new TextBox();
            label10 = new Label();
            label9 = new Label();
            TxtCustomerPhone = new TextBox();
            TxtCustomerBirthday = new TextBox();
            label8 = new Label();
            TxtCustomerAddress = new TextBox();
            label7 = new Label();
            TxtCustomerLName = new TextBox();
            label6 = new Label();
            TxtCustomerFName = new TextBox();
            label5 = new Label();
            TxtCustomerDocument = new TextBox();
            label4 = new Label();
            TxtCustomerId = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).BeginInit();
            tabPageCustomerDetail.SuspendLayout();
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
            label1.Size = new Size(238, 59);
            label1.TabIndex = 2;
            label1.Text = "Customers";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.providers;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 95);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageCustomerList);
            tabControl1.Controls.Add(tabPageCustomerDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 122);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 328);
            tabControl1.TabIndex = 1;
            // 
            // tabPageCustomerList
            // 
            tabPageCustomerList.Controls.Add(BtnClose);
            tabPageCustomerList.Controls.Add(BtnDelete);
            tabPageCustomerList.Controls.Add(BtnEdit);
            tabPageCustomerList.Controls.Add(BtnNew);
            tabPageCustomerList.Controls.Add(DgCustomer);
            tabPageCustomerList.Controls.Add(BtnSearch);
            tabPageCustomerList.Controls.Add(TxtSearch);
            tabPageCustomerList.Controls.Add(label2);
            tabPageCustomerList.Location = new Point(4, 24);
            tabPageCustomerList.Name = "tabPageCustomerList";
            tabPageCustomerList.Padding = new Padding(3);
            tabPageCustomerList.Size = new Size(792, 300);
            tabPageCustomerList.TabIndex = 0;
            tabPageCustomerList.Text = "Customer List";
            tabPageCustomerList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(626, 239);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(160, 50);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(626, 183);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(160, 50);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(626, 127);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(160, 50);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.BackgroundImageLayout = ImageLayout.None;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(626, 71);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(160, 50);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgCustomer
            // 
            DgCustomer.AllowUserToAddRows = false;
            DgCustomer.AllowUserToDeleteRows = false;
            DgCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgCustomer.Location = new Point(13, 71);
            DgCustomer.Name = "DgCustomer";
            DgCustomer.ReadOnly = true;
            DgCustomer.Size = new Size(609, 221);
            DgCustomer.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(572, 15);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(50, 50);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(13, 30);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(529, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Search customer";
            // 
            // tabPageCustomerDetail
            // 
            tabPageCustomerDetail.Controls.Add(BtnCancel);
            tabPageCustomerDetail.Controls.Add(BtnSave);
            tabPageCustomerDetail.Controls.Add(TxtCustomerEmail);
            tabPageCustomerDetail.Controls.Add(label10);
            tabPageCustomerDetail.Controls.Add(label9);
            tabPageCustomerDetail.Controls.Add(TxtCustomerPhone);
            tabPageCustomerDetail.Controls.Add(TxtCustomerBirthday);
            tabPageCustomerDetail.Controls.Add(label8);
            tabPageCustomerDetail.Controls.Add(TxtCustomerAddress);
            tabPageCustomerDetail.Controls.Add(label7);
            tabPageCustomerDetail.Controls.Add(TxtCustomerLName);
            tabPageCustomerDetail.Controls.Add(label6);
            tabPageCustomerDetail.Controls.Add(TxtCustomerFName);
            tabPageCustomerDetail.Controls.Add(label5);
            tabPageCustomerDetail.Controls.Add(TxtCustomerDocument);
            tabPageCustomerDetail.Controls.Add(label4);
            tabPageCustomerDetail.Controls.Add(TxtCustomerId);
            tabPageCustomerDetail.Controls.Add(label3);
            tabPageCustomerDetail.Location = new Point(4, 24);
            tabPageCustomerDetail.Name = "tabPageCustomerDetail";
            tabPageCustomerDetail.Padding = new Padding(3);
            tabPageCustomerDetail.Size = new Size(792, 300);
            tabPageCustomerDetail.TabIndex = 1;
            tabPageCustomerDetail.Text = "Customer Detail";
            tabPageCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(138, 228);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 50);
            BtnCancel.TabIndex = 17;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(33, 228);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 50);
            BtnSave.TabIndex = 16;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtCustomerEmail
            // 
            TxtCustomerEmail.Location = new Point(414, 183);
            TxtCustomerEmail.Name = "TxtCustomerEmail";
            TxtCustomerEmail.Size = new Size(240, 23);
            TxtCustomerEmail.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 163);
            label10.Name = "label10";
            label10.Size = new Size(36, 15);
            label10.TabIndex = 14;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 109);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 13;
            label9.Text = "Phone Number";
            // 
            // TxtCustomerPhone
            // 
            TxtCustomerPhone.Location = new Point(414, 128);
            TxtCustomerPhone.Name = "TxtCustomerPhone";
            TxtCustomerPhone.Size = new Size(240, 23);
            TxtCustomerPhone.TabIndex = 12;
            // 
            // TxtCustomerBirthday
            // 
            TxtCustomerBirthday.Location = new Point(414, 77);
            TxtCustomerBirthday.Name = "TxtCustomerBirthday";
            TxtCustomerBirthday.Size = new Size(240, 23);
            TxtCustomerBirthday.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(414, 61);
            label8.Name = "label8";
            label8.Size = new Size(106, 15);
            label8.TabIndex = 10;
            label8.Text = "Customer Birthday";
            // 
            // TxtCustomerAddress
            // 
            TxtCustomerAddress.Location = new Point(414, 30);
            TxtCustomerAddress.Name = "TxtCustomerAddress";
            TxtCustomerAddress.Size = new Size(240, 23);
            TxtCustomerAddress.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(414, 12);
            label7.Name = "label7";
            label7.Size = new Size(104, 15);
            label7.TabIndex = 8;
            label7.Text = "Customer Address";
            // 
            // TxtCustomerLName
            // 
            TxtCustomerLName.Location = new Point(12, 183);
            TxtCustomerLName.Name = "TxtCustomerLName";
            TxtCustomerLName.Size = new Size(240, 23);
            TxtCustomerLName.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 163);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 6;
            label6.Text = "Customer LastName";
            // 
            // TxtCustomerFName
            // 
            TxtCustomerFName.Location = new Point(12, 128);
            TxtCustomerFName.Name = "TxtCustomerFName";
            TxtCustomerFName.Size = new Size(240, 23);
            TxtCustomerFName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 109);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 4;
            label5.Text = "Customer FirstName";
            // 
            // TxtCustomerDocument
            // 
            TxtCustomerDocument.Location = new Point(12, 77);
            TxtCustomerDocument.Name = "TxtCustomerDocument";
            TxtCustomerDocument.Size = new Size(240, 23);
            TxtCustomerDocument.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 61);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 2;
            label4.Text = "Customer Document";
            // 
            // TxtCustomerId
            // 
            TxtCustomerId.Location = new Point(12, 30);
            TxtCustomerId.Name = "TxtCustomerId";
            TxtCustomerId.ReadOnly = true;
            TxtCustomerId.Size = new Size(240, 23);
            TxtCustomerId.TabIndex = 1;
            TxtCustomerId.Text = "0";
            TxtCustomerId.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 12);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 0;
            label3.Text = "Customer Id";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "CustomerView";
            Text = "Customer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageCustomerList.ResumeLayout(false);
            tabPageCustomerList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgCustomer).EndInit();
            tabPageCustomerDetail.ResumeLayout(false);
            tabPageCustomerDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPageCustomerList;
        private TabPage tabPageCustomerDetail;
        private Label label2;
        private TextBox TxtSearch;
        private Button BtnSearch;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgCustomer;
        private Label label3;
        private Label label6;
        private TextBox TxtCustomerFName;
        private Label label5;
        private TextBox TxtCustomerDocument;
        private Label label4;
        private TextBox TxtCustomerId;
        private Label label7;
        private TextBox TxtCustomerLName;
        private TextBox TxtCustomerAddress;
        private TextBox TxtCustomerEmail;
        private Label label10;
        private Label label9;
        private TextBox TxtCustomerPhone;
        private TextBox TxtCustomerBirthday;
        private Label label8;
        private Button BtnSave;
        private Button BtnCancel;
    }
}