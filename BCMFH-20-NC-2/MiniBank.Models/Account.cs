namespace MiniBank.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }
}
