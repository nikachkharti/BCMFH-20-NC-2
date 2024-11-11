using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Customer_Csv_Repository_Should
    {
        private readonly string _testFilePath = @"../../../../MiniBank.Tests/Data/Customers.csv";

        [Fact]
        public void Get_Multiple_Customers()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var expectedCount = 2;

            //Act
            var customers = repository.GetCustomers();

            //Assert
            Assert.Equal(expectedCount, customers.Count());
        }

        [Fact]
        public void Get_Empty_List_If_Data_File_Do_Not_Exists()
        {
            //Arrange
            var repository = new CustomerCsvRepository(string.Empty);

            //Act
            var customers = repository.GetCustomers();

            //Assert
            Assert.Empty(customers);
        }

        [Fact]
        public void Get_Individual_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var expected = new Customer()
            {
                Id = 1,
                Name = "Iakob Qobalia",
                PhoneNumber = "555337681",
                Email = "Iakob.Qobalia@gmail.com",
                IdentityNumber = "31024852345",
                Type = Models.AccountType.Phyisical
            };

            //Act
            var actual = repository.GetCustomer(1);

            //Assert
            Assert.Equal(expected, actual, new CustomerEqulityComparer());
        }

        [Fact]
        public void Add_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var expected = 3;
            var maxId = repository.GetCustomers().Max(x => x.Id);
            var newCustomer = new Customer()
            {
                Id = maxId + 1,
                Name = "Nikoloz Chkhartishvili",
                PhoneNumber = "558490588",
                Email = "Nikoloz.Chkhartishvili@gmail.com",
                IdentityNumber = "01024085083",
                Type = Models.AccountType.Phyisical
            };

            //Act
            repository.Create(newCustomer);

            var actual = repository.GetCustomers().Count();

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Update_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var updatedCustomer = new Customer()
            {
                Id = 3,
                Name = "Zaal Chkhartishvili",
                PhoneNumber = "558490588",
                Email = "Zaal.Chkhartishvili@gmail.com",
                IdentityNumber = "01024085083",
                Type = Models.AccountType.Phyisical
            };

            //Act
            repository.Update(updatedCustomer);

            //Assert
            var actual = repository.GetCustomer(3);
            Assert.Equal(updatedCustomer, actual);
        }

        [Fact]
        public void Delete_Customer()
        {
            //Arrange
            var repository = new CustomerCsvRepository(_testFilePath);
            var customerIdToDelete = 3;
            var expected = 2;

            //Act
            repository.Delete(customerIdToDelete);
            var actual = repository.GetCustomers().Count();

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
