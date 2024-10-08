using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModelView : Form, IPayModeView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public PayModelView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPagePayModeDetail);

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

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add new Pay Mode";
            };

            BtnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeList);
                tabControl1.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode";
            };

            BtnDelete.Click += delegate 
            {
                var result = MessageBox.Show(
                    "Are you sure you want  to delete the selected Pay Mode",
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
                    tabControl1.TabPages.Remove(tabPagePayModeDetail);
                    tabControl1.TabPages.Add(tabPagePayModeList);
                }
                MessageBox.Show(Message);
            };
            BtnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPagePayModeDetail);
                tabControl1.TabPages.Add(tabPagePayModeList);
            };
        }

        public string PayModeId 
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }
        }
        public string PayModeObservation 
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; }
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

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        //Singleton

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
