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
    public partial class CustomerView : Form, ICustomerView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageCustomerDetail);

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

                tabControl1.TabPages.Remove(tabPageCustomerList);
                tabControl1.TabPages.Add(tabPageCustomerDetail);
                tabPageCustomerDetail.Text = "Add new Customer";
            };

            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomerList);
                tabControl1.TabPages.Add(tabPageCustomerDetail);
                tabPageCustomerDetail.Text = "Edit Customer";
            };

            BtnDelete.Click += delegate
            {
                var result = MessageBox.Show(
                    "Are you sure you want to delete the selected Customer",
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
                    tabControl1.TabPages.Remove(tabPageCustomerDetail);
                    tabControl1.TabPages.Add(tabPageCustomerList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomerDetail);
                tabControl1.TabPages.Add(tabPageCustomerList);  
            };
        }

        public string CustomerId 
        {
            get { return TxtCustomerId.Text; }
            set { TxtCustomerId.Text = value; }
        }
        public string CustomerDocument 
        {
            get { return TxtCustomerDocument.Text; }
            set { TxtCustomerDocument.Text = value; }
        }
        public string CustomerFirstName 
        {
            get { return TxtCustomerFName.Text; }
            set { TxtCustomerFName.Text = value; }
        }
        public string CustomerLastName 
        {
            get { return TxtCustomerLName.Text; }
            set { TxtCustomerLName.Text = value; }
        }
        public string CustomerAddress 
        {
            get { return TxtCustomerAddress.Text; }
            set { TxtCustomerAddress.Text = value; }
        }
        public string CustomerBirthday 
        {
            get { return TxtCustomerBirthday.Text; }
            set { TxtCustomerBirthday.Text = value; }
        }
        public string CustomerPhoneNumber 
        {
            get { return TxtCustomerPhone.Text; }
            set { TxtCustomerPhone.Text = value; }
        }
        public string CustomerEmail 
        {
            get { return TxtCustomerEmail.Text; }
            set { TxtCustomerEmail.Text = value; }
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

        public void SetCustomerListBildingSource(BindingSource customerList)
        {
            DgCustomer.DataSource = customerList;
        }

        private static CustomerView instace;

        public static CustomerView GetInstace(Form parentContainer)
        {
            if (instace == null || instace.IsDisposed)
            {
                instace = new CustomerView();
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
