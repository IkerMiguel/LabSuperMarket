using Supermarket_mvp._Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        CategorieId cat = new CategorieId();

        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add new product";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit product";
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want  to delete the selected product",
                    "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
            };
        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductPrice
        {
            get { return TxtProductPrice.Text; }
            set { TxtProductPrice.Text = value; }
        }
        public string ProductStock
        {
            get { return TxtProductStock.Text; }
            set { TxtProductStock.Text = value; }
        }
        public string ProductCategorie
        {
            get { return ComboBoxProductCategory.Text; }
            set { ComboBoxProductCategory.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }


        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetProductListBildingSource(BindingSource productList)
        {
            DgProducts.DataSource = productList;
        }

        private static ProductView instace;

        public static ProductView GetInstace(Form parentContainer)
        {
            if (instace == null || instace.IsDisposed)
            {
                instace = new ProductView();
                instace.MdiParent = parentContainer;

                instace.FormBorderStyle = FormBorderStyle.None;
                instace.Dock = DockStyle.Fill;
            }
            else
            {
                if (instace.WindowState == FormWindowState.Minimized)
                {
                    instace.WindowState = FormWindowState.Normal;
                }
            }
            return instace;
        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            ComboBoxProductCategory.DataSource = cat.CargarCombo();

            ComboBoxProductCategory.DisplayMember = "Categorie_Id";
            ComboBoxProductCategory.ValueMember = "Categorie_Id";
        }
    }
}
