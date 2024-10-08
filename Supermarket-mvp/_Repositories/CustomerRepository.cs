using Microsoft.Data.SqlClient;
using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand()) 
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER By Customer_Id DESC";
                using (var reader = command.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.Document = reader["Customer_Document"].ToString();
                        customerModel.FirstName = reader["Customer_First_Name"].ToString();
                        customerModel.LastName = reader["Customer_Last_Name"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Customer_Birthday"];
                        customerModel.PhoneNumber = reader["Customer_Phone"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerDocument = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer
                                        WHERE Customer_Id=@Id or Customer_Document LIKE @document+ '%'
                                        ORDER BY Customer_Id DESC";
                command.Parameters.Add("@Id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerDocument;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.Document = reader["Customer_Document"].ToString();
                        customerModel.FirstName = reader["Customer_First_Name"].ToString();
                        customerModel.LastName = reader["Customer_Last_Name"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = (DateTime)reader["Customer_Birthday"];
                        customerModel.PhoneNumber = reader["Customer_Phone"].ToString();
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }

            return customerList;
        }

        public void Update(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }
    }
}
