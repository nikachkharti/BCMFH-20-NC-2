using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using MiniBank.Models;

namespace MiniBank.Repository
{
    public class SqlClientOperationRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCMFH20NC;Trusted_Connection=true;TrustServerCertificate=true";
        SqlClientAccountRepository sqlClietnAccountRepository = new();


        public async Task Withdraw(int accountId, decimal amount)
        {
            if (amount <= 0 || accountId <= 0)
            {
                throw new ArgumentException("Invalid arguments passed");
            }

            var account = await sqlClietnAccountRepository.GetAccount(accountId);

            if (account is null)
            {
                throw new NullReferenceException("Account not found");
            }

            if (account.Balance >= amount)
            {
                account.Balance -= amount;
            }
            else
            {
                throw new ArgumentException("Insufficient funds to withdraw");
            }

            await sqlClietnAccountRepository.Update(account);
            await Create(new Operation()
            {
                OperationType = OperationType.Credit,
                Currency = account.Currency,
                Amount = amount,
                HappendAt = DateTime.Now,
                AccountId = account.Id
            });
        }

        public async Task Insert(int accountId, decimal amount)
        {
            if (amount <= 0 || accountId <= 0)
            {
                throw new ArgumentException("Invalid arguments passed");
            }

            var account = await sqlClietnAccountRepository.GetAccount(accountId);

            if (account is null)
            {
                throw new NullReferenceException("Account not found");
            }

            account.Balance += amount;

            await sqlClietnAccountRepository.Update(account);


            await Create(new Operation()
            {
                OperationType = OperationType.Credit,
                Currency = account.Currency,
                Amount = amount,
                HappendAt = DateTime.Now,
                AccountId = account.Id
            });
        }

        public async Task Transfer(int sourceAccountId, int destinationAccountId, decimal amount)
        {
            if (amount <= 0 || sourceAccountId <= 0 || destinationAccountId <= 0)
            {
                throw new ArgumentException("Invalid arguments passed");
            }

            var sourceAccount = await sqlClietnAccountRepository.GetAccount(sourceAccountId);
            var destinationAccount = await sqlClietnAccountRepository.GetAccount(destinationAccountId);

            if (sourceAccount is null || destinationAccount is null)
            {
                throw new NullReferenceException("Account not found");
            }

            if (sourceAccount.Balance >= amount)
            {
                sourceAccount.Balance -= amount;
                destinationAccount.Balance += amount;
            }
            else
            {
                throw new ArgumentException("Insufficient funds to withdraw");
            }

            await sqlClietnAccountRepository.Update(sourceAccount);
            await sqlClietnAccountRepository.Update(destinationAccount);

            await Create(new Operation()
            {
                OperationType = OperationType.Debit,
                Currency = sourceAccount.Currency,
                Amount = amount,
                HappendAt = DateTime.Now,
                AccountId = sourceAccount.Id
            });

            await Create(new Operation()
            {
                OperationType = OperationType.Credit,
                Currency = destinationAccount.Currency,
                Amount = amount,
                HappendAt = DateTime.Now,
                AccountId = destinationAccount.Id
            });
        }


        //ახალი ჩანაწერი Operation ცხრილში.
        public async Task Create(Operation operation)
        {
            string commandText = "spCreateOperation";

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("operationType", operation.OperationType);
                    command.Parameters.AddWithValue("currency", operation.Currency);
                    command.Parameters.AddWithValue("amount", operation.Amount);
                    command.Parameters.AddWithValue("happendAt", operation.HappendAt);
                    command.Parameters.AddWithValue("accountId", operation.AccountId);

                    await connection.OpenAsync();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }


    }
}
