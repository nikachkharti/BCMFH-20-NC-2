using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Customer_Csv_Repository_Should
    {
        [Fact]
        public void Get_All_Customers()
        {
            //Arrange
            var customerRepository = new CustomerCsvRepository(@"../../../../MiniBank.Tests/Data/Customers.csv");
            var expected = 2;

            //Act
            var actual = customerRepository.GetCustomers();

            //Assert
            Assert.Equal(expected, actual.Count);
        }

        [Fact]
        public void Get_Single_Customer()
        {
            //Arrange
            var customerRepository = new CustomerCsvRepository(@"../../../../MiniBank.Tests/Data/Customers.csv");
            Customer expected = new()
            {
                Id = 1,
                Name = "Iakob Qobalia",
                IdentityNumber = "31024852345",
                PhoneNumber = "555337681",
                Email = "Iakob.Qobalia@gmail.com",
                Type = Models.Type.Phyisical,
            };

            //Act
            var actual = customerRepository.GetCustomer(1);

            //Assert
            Assert.Equal(expected, actual, new CustomerEqulityComparer());
        }
    }
}
