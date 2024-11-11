using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Account_Json_Repository_Should
    {
        private readonly string _testFilePath = @"../../../../MiniBank.Tests/Data/Accounts.json";

        [Fact]
        public void Get_Multiple_Accounts()
        {
            //Arrange
            var repository = new AccountJsonRepository(_testFilePath);
            var expectedCount = 5;

            //Act
            var customers = repository.GetAccounts();

            //Assert
            Assert.Equal(expectedCount, customers.Count());
        }

        [Fact]
        public void Get_Single_Account()
        {
            //Arrange
            var repository = new AccountJsonRepository(_testFilePath);
            var expected = new Account()
            {
                Id = 1,
                Iban = "GE94SB5621487456325158",
                Currency = "GEL",
                Balance = 6712.12m,
                CustomerId = 1,
                Name = "Deposit account"
            };

            //Act
            var actual = repository.GetAccount(1);

            //Assert
            Assert.Equal(expected, actual, new AccountEquilityComparer());
        }

        [Fact]
        public void Add_Account()
        {
            //Arrange
            var repository = new AccountJsonRepository(_testFilePath);
            var expected = 6;
            var maxId = repository.GetAccounts().Max(x => x.Id);
            var newAccount = new Account()
            {
                Id = maxId + 1,
                Iban = "GE94SB5621487456325151",
                Currency = "GEL",
                Balance = 0.00m,
                CustomerId = 1,
                Name = string.Empty
            };

            //Act
            repository.Create(newAccount);
            var actual = repository.GetAccounts().Count;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Delete_Account()
        {
            //Arrange
            var repository = new AccountJsonRepository(_testFilePath);
            var customerIdToDelete = 1;
            var expected = 5;

            //Act
            repository.Delete(customerIdToDelete);
            var actual = repository.GetAccounts().Count();

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void Update_Account()
        {
            //Arrange
            var repository = new AccountJsonRepository(_testFilePath);
            var updatedAccount = new Account()
            {
                Id = 5,
                Iban = "GE90SB5621487456385159",
                Currency = "EUR",
                Balance = 500.00m,
                CustomerId = 2,
                Name = string.Empty
            };

            //Act
            repository.Update(updatedAccount);

            //Assert
            var actual = repository.GetAccount(5);
            Assert.Equal(updatedAccount, actual);
        }
    }
}
