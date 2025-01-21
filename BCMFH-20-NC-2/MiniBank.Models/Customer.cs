using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace MiniBank.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public CustomerType Type { get; set; }
    }

    public class CustomerEqulityComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y) => x.Id == y.Id &&
                x.Name.ToLower().Trim() == y.Name.ToLower().Trim() &&
                x.IdentityNumber.ToLower().Trim() == y.IdentityNumber.ToLower().Trim() &&
                x.PhoneNumber.Trim() == y.PhoneNumber.Trim() &&
                x.Email.Trim().ToLower() == y.Email.Trim().ToLower() &&
                x.Type == y.Type;

        public int GetHashCode([DisallowNull] Customer obj) => obj.Name.Length;
    }

}
