using MiniBank.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;
using MiniBank.Repository.Interfaces;

namespace MiniBank.Repository
{
    public class SqlClientCustomerRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCMFH20NC;Trusted_Connection=true;TrustServerCertificate=true";

        private readonly IRepository<Customer> _repository;

        public SqlClientCustomerRepository()
        {
            _repository = new Repositroy<Customer>(_connectionString);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            string commandText = "spGetAllCustomers";
            var result = await _repository.GetAll(commandText, null, CommandType.StoredProcedure);

            return result.ToList();
        }
        public async Task<Customer> GetCustomer(int id)
        {
            string commandText = "spGetSingleCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",id }
            };

            var result = await _repository.Get(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> Create(Customer customer)
        {
            string commandText = "spCreateCustomer";

            var parameters = new Dictionary<string, object>()
            {
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.Type }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> Update(Customer customer)
        {
            string commandText = "spUpdateCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",customer.Id },
                {"@name",customer.Name },
                {"@identityNumber",customer.IdentityNumber },
                {"@phoneNumber",customer.PhoneNumber },
                {"@email",customer.Email },
                {"@customerType",customer.Type }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
        public async Task<int> Delete(int id)
        {
            string commandText = "spDeleteCustomer";
            var parameters = new Dictionary<string, object>()
            {
                {"@customerId",id }
            };

            var result = await _repository.Execute(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }
    }
}
