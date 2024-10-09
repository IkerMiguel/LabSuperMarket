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
    public partial class CategorieView : Form, ICategorieView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategorieView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCategorieDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            BtnSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Add new Categorie";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieList);
                tabControl1.TabPages.Add(tabPageCategorieDetail);
                tabPageCategorieDetail.Text = "Edit Categorie";
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want  to delete the selected Categorie",
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
                    tabControl1.TabPages.Remove(tabPageCategorieDetail);
                    tabControl1.TabPages.Add(tabPageCategorieList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategorieDetail);
                tabControl1.TabPages.Add(tabPageCategorieList);
            };
        }

        public string CategorieId 
        {
            get { return TxtCategorieId.Text; }
            set { TxtCategorieId.Text = value; }
        }
        public string CategorieName 
        {
            get { return TxtCategorieName.Text; }
            set { TxtCategorieName.Text = value; }
        }
        public string CategorieDescription 
        {
            get { return TxtCategorieDescription.Text; }
            set { TxtCategorieDescription.Text = value; }
        }

        public string SearchValue
        {
            get { return BtnSearch.Text; }
            set { BtnSearch.Text = value; }
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

        public void SetCategorieListBildingSource(BindingSource categorieList)
        {
            DgCategorie.DataSource = categorieList;
        }

        private static PayModelView instace;

        public static PayModelView GetInstace(Form parentContainer)
        {
            if (instace == null || instace.IsDisposed)
            {
                instace = new PayModelView();
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
    }
}
