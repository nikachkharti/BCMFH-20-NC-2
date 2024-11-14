using MiniBank.Models;
using System.Xml.Linq;

namespace MiniBank.Repository
{
    public class OperationXmlRepository
    {
        private readonly string _filePath;
        private List<Operation> _operations;
        private readonly AccountJsonRepository _accountJsonRepository;

        public OperationXmlRepository(string filePath, AccountJsonRepository accountJsonRepository)
        {
            _filePath = filePath;
            _operations = LoadData();
            _accountJsonRepository = accountJsonRepository;
        }

        public OperationXmlRepository(string filePath)
        {
            _filePath = filePath;
            _operations = LoadData();
        }

        public List<Operation> GetOperations() => _operations;
        public List<Operation> GetAccountOperations(int accountId) => _operations.Where(op => op.AccountId == accountId).ToList();
        public List<Operation> GetCustomerOperations(int customerId) => _operations.Where(op => op.CustomerId == customerId).ToList();
        public Operation GetOperation(int id) => _operations.FirstOrDefault(op => op.Id == id);

        public void Credit(Operation operation)
        {
            operation.Id = _operations.Any() ? _operations.Max(op => op.Id) + 1 : 1;
            _operations.Add(operation);
            SaveData();

            var accountToCredit = _accountJsonRepository.GetAccount(operation.AccountId);

            if (accountToCredit == null || accountToCredit.Currency != operation.Currency)
            {
                throw new InvalidOperationException("Account don't exists or credit operation currency is different from account");
            }

            accountToCredit.Balance += operation.Amount;
            _accountJsonRepository.Update(accountToCredit);
            _accountJsonRepository.SaveData();
        }

        public void Debit(Operation operation)
        {
            operation.Id = _operations.Any() ? _operations.Max(op => op.Id) + 1 : 1;
            _operations.Add(operation);
            SaveData();

            var accountToCredit = _accountJsonRepository.GetAccount(operation.AccountId);

            if (accountToCredit == null || accountToCredit.Currency != operation.Currency)
            {
                throw new InvalidOperationException("Account don't exists or credit operation currency is different from account");
            }

            accountToCredit.Balance -= operation.Amount;
            _accountJsonRepository.Update(accountToCredit);
            _accountJsonRepository.SaveData();
        }


        //public void Create(Operation operation)
        //{
        //    operation.Id = _operations.Any() ? _operations.Max(op => op.Id) + 1 : 1;
        //    _operations.Add(operation);
        //    SaveData();
        //}

        //public void Update(Operation operation)
        //{
        //    var index = _operations.FindIndex(op => op.Id == operation.Id);
        //    if (index >= 0)
        //    {
        //        _operations[index] = operation;
        //        SaveData();
        //    }
        //}

        //public void Delete(int id)
        //{
        //    var operation = _operations.FirstOrDefault(op => op.Id == id);

        //    if (operation != null)
        //    {
        //        _operations.Remove(operation);
        //        SaveData();
        //    }
        //}

        public void SaveData()
        {
            var doc = new XDocument(
                new XElement("Operations",
                    _operations.Select(op =>
                        new XElement("Operation",
                            new XElement("Id", op.Id),
                            new XElement("AccountId", op.AccountId),
                            new XElement("CustomerId", op.CustomerId),
                            new XElement("Type", op.OperationType.ToString()),
                            new XElement("Currency", op.Currency),
                            new XElement("Amount", op.Amount),
                            new XElement("HappendAt", op.HappendAt)
                        )
                    )
                )
            );

            doc.Save(_filePath);
        }

        private List<Operation> LoadData()
        {
            if (!File.Exists(_filePath))
                return new List<Operation>();

            if (File.ReadAllText(_filePath).Trim() == "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" || string.IsNullOrWhiteSpace(File.ReadAllText(_filePath)))
                return new List<Operation>();

            var doc = XDocument.Load(_filePath);

            if (doc.Root == null || doc.Root.Name != "Operations")
                return new List<Operation>();

            return doc.Root.Elements("Operation")
                .Select(op => new Operation
                {
                    Id = (int)op.Element("Id"),
                    AccountId = (int)op.Element("AccountId"),
                    CustomerId = (int)op.Element("CustomerId"),
                    OperationType = Enum.Parse<OperationType>((string)op.Element("Type")),
                    Currency = (string)op.Element("Currency"),
                    Amount = (decimal)op.Element("Amount"),
                    HappendAt = DateTime.Parse(op.Element("HappendAt")?.Value ?? DateTime.MinValue.ToString())
                })
                .ToList();
        }
    }
}
