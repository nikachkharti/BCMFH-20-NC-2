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
            var result = await _sqlClientCustomerRepository.GetCustomer(1);
        }

        [Fact]
        public async Task Add_Customers()
        {
            Customer newCustomer = new()
            {
                Email = "Giorgi@gmail.com",
                IdentityNumber = "12356987415",
                PhoneNumber = "559887744",
                Name = "Giorgi Otarashvili",
                Type = CustomerType.Phyisical
            };

            await _sqlClientCustomerRepository.Create(newCustomer);
        }

        [Fact]
        public async Task Update_Customers()
        {
            Customer updatedCustomer = new()
            {
                Id = 1,
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
            await _sqlClientCustomerRepository.Delete(1);
        }
    }
}
