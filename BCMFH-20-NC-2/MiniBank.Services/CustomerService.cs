using MiniBank.Models;
using MiniBank.Repository.Interfaces;
using MiniBank.Services.Interfaces;
using System.Data;

namespace MiniBank.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddCustomer(Customer customer)
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

            var result = await _customerRepository.Execute(commandText, parameters, CommandType.StoredProcedure);
        }

        public async Task DeleteCustomer(int id)
        {
            string commandText = "spDeleteCustomer";
            var parameters = new Dictionary<string, object>()
                {
                    {"@customerId",id }
                };

            var result = await _customerRepository.Execute(commandText, parameters, CommandType.StoredProcedure);
        }

        public async Task<Customer> GetCustomer(int id)
        {
            string commandText = "spGetSingleCustomer";
            var parameters = new Dictionary<string, object>()
                {
                    {"@customerId",id }
                };

            var result = await _customerRepository.Get(commandText, parameters, CommandType.StoredProcedure);
            return result;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            string commandText = "spGetAllCustomers";
            var result = await _customerRepository.GetAll(commandText, null, CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task UpdateCustomer(Customer customer)
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

            var result = await _customerRepository.Execute(commandText, parameters, CommandType.StoredProcedure);
        }
    }
}
