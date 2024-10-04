namespace Lecture7.Minibank.Models
{
    public class Account
    {
        private string accountNumber;
        private string currency;
        private decimal balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                if (value.Length == 22)
                {
                    accountNumber = value;
                }
            }
        }
        public string Currency
        {
            get { return currency; }
            set
            {
                if (value.Length == 3)
                {
                    currency = value.ToUpper();
                }
            }
        }
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value > 0)
                {
                    balance = value;
                }
            }
        }


        public void Withdraw(decimal amountToWithdraw)
        {
            if (balance >= amountToWithdraw)
            {
                balance -= amountToWithdraw;
            }
        }
        public void Deposit(decimal amountToDeposit)
        {
            balance += amountToDeposit;
        }
        public void Transfer(Account account, decimal amountToTransfer)
        {
            if (balance >= amountToTransfer)
            {
                balance -= amountToTransfer;
                account.Balance += amountToTransfer;
            }
        }
    }
}
