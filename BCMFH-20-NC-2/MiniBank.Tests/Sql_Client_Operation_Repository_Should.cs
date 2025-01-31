using MiniBank.Repository;

namespace MiniBank.Tests
{
    public class Sql_Client_Operation_Repository_Should
    {
        private SqlClientOperationRepository _sqlClientOperationRepository = new();

        [Fact]
        public async Task Insert_Amount()
        {
            const decimal withdrawAmount = 2;
            const int accountId = 1;

            await _sqlClientOperationRepository.Insert(accountId, withdrawAmount);
        }


        [Fact]
        public async Task Withdraw_Amount()
        {
            const decimal withdrawAmount = 2;
            const int accountId = 4;

            await _sqlClientOperationRepository.Withdraw(accountId, withdrawAmount);
        }

        [Fact]
        public async Task Transfer_Amount()
        {
            const decimal transferAmount = 2;
            const int sourceAccountId = 1;
            const int destinationAccountId = 4;

            await _sqlClientOperationRepository.Transfer(sourceAccountId, destinationAccountId, transferAmount);
        }
    }
}
