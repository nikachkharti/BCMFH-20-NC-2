using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Sql_Client_Customer_Repository_Should
    {
        private SqlClientCustomerRepository _sqlClientCustomerRepository = new();

        [Fact]
        public async Task Get_All_Customers()
        {
            var result = await _sqlClientCustomerRepository.GetCustomers();
        }

        [Fact]
        public async Task Get_Single_Customer()
        {
            var result = await _sqlClientCustomerRepository.GetCustomer(2);
        }

        [Fact]
        public async Task Add_Customers()
        {
            Customer newCustomer = new()
            {
                Email = "Davit@gmail.com",
                IdentityNumber = "01024087596",
                PhoneNumber = "558779966",
                Name = "Davit Davitashvili",
                Type = CustomerType.Phyisical
            };

            await _sqlClientCustomerRepository.Create(newCustomer);
        }

        [Fact]
        public async Task Update_Customers()
        {
            Customer updatedCustomer = new()
            {
                Id = 4,
                Email = "Davit@gmail.com",
                IdentityNumber = "12356987415",
                PhoneNumber = "559887744",
                Name = "Davit Otarashvili",
                Type = CustomerType.Phyisical
            };

            await _sqlClientCustomerRepository.Update(updatedCustomer);
        }

        [Fact]
        public async Task Delete_Customer()
        {
            await _sqlClientCustomerRepository.Delete(4);
        }
    }
}
