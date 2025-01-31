using System.Diagnostics.CodeAnalysis;

namespace MiniBank.Models
{
    public class Operation
    {
        public int Id { get; set; }
        public OperationType OperationType { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public int AccountId { get; set; }
        public DateTime HappendAt { get; set; } = DateTime.Now;
    }

    public class OperationEquilityComparer : IEqualityComparer<Operation>
    {
        public bool Equals(Operation x, Operation y) => x.Id == y.Id &&
            x.OperationType == y.OperationType &&
            x.HappendAt == y.HappendAt &&
            x.AccountId == y.AccountId &&
            x.Amount == y.Amount;

        public int GetHashCode([DisallowNull] Operation obj) => obj.Id;
    }
}
