using MiniBank.Models;
using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Sql_Client_Account_Repository_Should
    {
        private SqlClientAccountRepository _sqlClientAccountRepository = new();

        [Fact]
        public async Task Get_All_Accounts()
        {
            var result = await _sqlClientAccountRepository.GetAccounts();
        }

        [Fact]
        public async Task Get_Single_Account()
        {
            var result = await _sqlClientAccountRepository.GetAccount(4);
        }


        [Fact]
        public async Task Add_Account()
        {
            Account account = new()
            {
                Iban = "GEL4567894512345678910",
                Balance = 10,
                Currency = "GEL",
                CustomerId = 4,
                Name = "Salary"
            };

            await _sqlClientAccountRepository.Create(account);
        }


        [Fact]
        public async Task Update_Account()
        {
            Account account = new()
            {
                Iban = "GEL4567894512345678945",
                Balance = 100,
                Currency = "GEL",
                CustomerId = 2,
                Name = "Salary"
            };

            await _sqlClientAccountRepository.Update(account);
        }


        [Fact]
        public async Task Delete_Account()
        {
            await _sqlClientAccountRepository.Delete(4);
        }
    }
}
