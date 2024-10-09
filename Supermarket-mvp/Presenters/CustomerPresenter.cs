using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBildingSource(customerBindingSource);

            LoadAllCustomerList();

            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomerModel();
            customer.Id = Convert.ToInt32(view.CustomerId);
            customer.Document = view.CustomerDocument;
            customer.FirstName = view.CustomerFirstName;
            customer.LastName = view.CustomerLastName;
            customer.Address = view.CustomerAddress;
            customer.Birthday = DateTime.Parse(view.CustomerBirthday);
            customer.PhoneNumber = view.CustomerPhoneNumber;
            customer.Email = view.CustomerEmail;

            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer Edit Successfuly";
                }
                else 
                {
                    repository.Add(customer);
                    view.Message = "Customer added Successfuly";
                }
                view.IsSuccessful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.CustomerId = "";
            view.CustomerDocument = "";
            view.CustomerFirstName = "";
            view.CustomerLastName = "";
            view.CustomerAddress = "";
            view.CustomerBirthday = "";
            view.CustomerPhoneNumber = "";
            view.CustomerEmail = "";
        }

        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel) customerBindingSource.Current;
                repository.Delete(customer.Id);
                view.IsSuccessful = true;
                view.Message = "Customer deleted Successfuly";
                LoadAllCustomerList();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete Customer";
            }
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current;
            view.CustomerId = customer.Id.ToString();
            view.CustomerDocument = customer.Document;
            view.CustomerFirstName = customer.FirstName;
            view.CustomerLastName = customer.LastName;
            view.CustomerAddress = customer.Address;
            view.CustomerBirthday = customer.Birthday.ToString();
            view.CustomerPhoneNumber = customer.PhoneNumber;
            view.CustomerEmail = customer.Email;

            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}
