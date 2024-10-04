namespace Lecture7.Minibank.Models
{
    public class Client
    {
        private string personalNumber;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber
        {
            get { return personalNumber; }
            set
            {
                if (value.Length == 11)
                {
                    personalNumber = value;
                }
            }
        }

        public Account Account { get; set; }

        public override string ToString()
        {
            return $"I am {FirstName} {LastName} Personal number is {PersonalNumber} my balance is {Account.Balance} {Account.Currency}";
        }


    }
}
