using Microsoft.Data.SqlClient;
using MiniBank.Models;
using MiniBank.Repository.Interfaces;
using System.Data;

namespace MiniBank.Repository
{
    public class SqlClientAccountRepository
    {
        private const string _connectionString = "Server=DESKTOP-SCSHELD\\SQLEXPRESS;Database=MiniBankBCMFH20NC;Trusted_Connection=true;TrustServerCertificate=true";

        private readonly IRepository<Account> _repository;

        public SqlClientAccountRepository()
        {
            _repository = new Repositroy<Account>(_connectionString);
        }

        public async Task<List<Account>> GetAccounts()
        {
            string commandText = "spGetAccounts";
            var result = await _repository.GetAll(commandText, null, CommandType.StoredProcedure);

            return result.ToList();
        }
        public async Task<List<Account>> GetAccountsOfCustomer(int customerId)
        {
            string commandText = "spGetAccountsOfCustomer";
            List<Account> result = new();

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("customerId", customerId);
                    await connection.OpenAsync();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        Account account = new();
                        account.Id = reader.GetInt32(0);
                        account.Iban = reader.GetString(1);
                        account.Currency = reader.GetString(2);
                        account.Balance = reader.GetDecimal(3);
                        account.Name = reader.GetString(4);
                        account.CustomerId = reader.GetInt32(5);

                        result.Add(account);
                    }
                }
            }

            return result;
        }
        public async Task<Account> GetAccount(int id)
        {
            string commandText = "spGetAccount";
            Account result = new();

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("accountId", id);

                    await connection.OpenAsync();

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    while (await reader.ReadAsync())
                    {
                        result.Id = reader.GetInt32(0);
                        result.Iban = reader.GetString(1);
                        result.Currency = reader.GetString(2);
                        result.Balance = reader.GetDecimal(3);
                        result.Name = reader.GetString(4);
                        result.CustomerId = reader.GetInt32(5);
                    }
                }
            }

            return result;
        }
        public async Task Create(Account account)
        {
            string commandText = "spCreateAccount";

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();

                    command.Parameters.AddWithValue("iban", account.Iban);
                    command.Parameters.AddWithValue("currency", account.Currency);
                    command.Parameters.AddWithValue("balance", account.Balance);
                    command.Parameters.AddWithValue("name", account.Name);
                    command.Parameters.AddWithValue("customerId", account.CustomerId);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Delete(int id)
        {
            string commandText = "spDeleteAccount";

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();

                    command.Parameters.AddWithValue("accountId", id);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
        public async Task Update(Account account)
        {
            string commandText = "spUpdateAccount";

            using (SqlConnection connection = new(_connectionString))
            {
                using (SqlCommand command = new(commandText, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    await connection.OpenAsync();

                    command.Parameters.AddWithValue("accountId", account.Id);
                    command.Parameters.AddWithValue("iban", account.Iban);
                    command.Parameters.AddWithValue("currency", account.Currency);
                    command.Parameters.AddWithValue("balance", account.Balance);
                    command.Parameters.AddWithValue("name", account.Name);
                    command.Parameters.AddWithValue("customerId", account.CustomerId);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
