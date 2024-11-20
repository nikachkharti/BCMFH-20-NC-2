using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace MiniBank.Models
{
    public class Account
    {
        public int Id { get; set; }

        //TODO დაწერეთ ატრიბუტი რომელიც შეამოწმებს რომ Iban აუცილებლად უნდა იყოს 22 სიგრძის
        public string Iban { get; set; }

        //TODO დაწერეთ ატრიბუტი რომელიც შეამოწმებს რომ Currency აუცილებლად უნდა იყოს 3 სიგრძის
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }
    public class AccountEquilityComparer : IEqualityComparer<Account>
    {
        public bool Equals(Account x, Account y) => x.Id == y.Id &&
                x.Iban.Trim().ToLower() == y.Iban.Trim().ToLower() &&
                x.Currency.Trim().ToLower() == y.Currency.Trim().ToLower() &&
                x.Balance == y.Balance &&
                x.CustomerId == y.CustomerId;

        public int GetHashCode([DisallowNull] Account obj) => obj.Id;
    }
}
