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
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customer VALUES (@document, @firstName, @lastName, @address, @birthday, @phoneNumber, @Email)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerModel.FirstName;
                command.Parameters.Add("@observation", SqlDbType.NVarChar).Value = payModeModel.Observation;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            throw new NotImplementedException();
        }

        public void Update(CustomerModel customerModel)
        {
            throw new NotImplementedException();
        }
    }
}
