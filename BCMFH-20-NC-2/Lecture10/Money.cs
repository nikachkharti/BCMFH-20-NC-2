namespace Lecture10
{
    public class Money
    {
        public string Currency { get; set; }
        public decimal Amount { get; set; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(first.Amount + second.Amount, first.Currency)
                : null;


            //if (first.Currency.Length == 3 && second.Currency.Length == 3 && first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
            //{
            //    return new Money(first.Amount + second.Amount, first.Currency);
            //}
            //return null;
        }


        public static Money operator -(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(first.Amount - second.Amount, first.Currency)
                : null;
        }

        public static Money operator *(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(first.Amount * second.Amount, first.Currency)
                : null;
        }

        public static Money operator /(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? new Money(first.Amount / second.Amount, first.Currency)
                : null;
        }


        public static bool operator >(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount > second.Amount
                : false;
        }


        public static bool operator <(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount < second.Amount
                : false;
        }


        public static bool operator <=(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount <= second.Amount
                : false;
        }

        public static bool operator >=(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount >= second.Amount
                : false;
        }

        public static bool operator ==(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount == second.Amount
                : false;
        }

        public static bool operator !=(Money first, Money second)
        {
            return
                (first.Currency.Length == 3 && second.Currency.Length == 3 &&
                first.Currency.Trim().ToUpper() == second.Currency.Trim().ToUpper())
                ? first.Amount != second.Amount
                : false;
        }

        public static Money operator ++(Money arg) => new Money(arg.Amount += 1, arg.Currency);
        public static Money operator --(Money arg) => new Money(arg.Amount -= 1, arg.Currency);


        public override int GetHashCode() => base.GetHashCode();
        public override bool Equals(object obj) => base.Equals(obj);
        public override string ToString() => $"{Amount} {Currency}";
    }
}
