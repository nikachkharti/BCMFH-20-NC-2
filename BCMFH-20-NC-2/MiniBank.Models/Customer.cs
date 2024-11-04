namespace MiniBank.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Type Type { get; set; }
    }
}
