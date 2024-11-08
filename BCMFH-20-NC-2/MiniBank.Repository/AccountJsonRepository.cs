using MiniBank.Models;

namespace MiniBank.Repository
{
    public class AccountJsonRepository
    {
        private readonly string _filePath;
        private readonly List<Account> _accounts;

        public AccountJsonRepository(string filePath)
        {
            _filePath = filePath;
            _accounts = LoadData();
        }

        public List<Account> GetAccounts()
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAccounts(int customerId)
        {
            throw new NotImplementedException();
        }

        public Account GetAccount(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(Account account)
        {
            throw new NotImplementedException();
        }

        public void Update(Account account)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        private void SaveData()
        {
            throw new NotImplementedException();
        }

        private List<Account> LoadData()
        {
            throw new NotImplementedException();
        }
    }
}
