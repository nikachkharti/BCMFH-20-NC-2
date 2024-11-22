
const decimal ticketPrice = 50.0m;

CompanyAccount companyAccount = new("123", 0);
Customer david = new("David", 100.0m);
Customer george = new("Georges", 100.0m);

//ყიდვვის ლოგიკა უნდა იყოს მრავალნაკადური

void PurchaseTicket(Customer customer)
{
    if (customer.Balance > ticketPrice)
    {
        Thread.Sleep(10);
        customer.Balance -= ticketPrice;
        companyAccount.Balance += ticketPrice;

        Console.WriteLine($"{customer.Name} has {customer.Balance}$");
        Console.WriteLine($"Company has {companyAccount.Balance}$");
    }
}



public class Customer
{
    public string Name { get; set; }
    public decimal Balance { get; set; }

    public Customer(string name, decimal balance)
    {
        Name = name;
        Balance = balance;
    }
}

class CompanyAccount
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public CompanyAccount(string accountNumber, decimal balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }
}










#region 1
//Thread.CurrentThread.Name = "Main Thread";
//Thread.CurrentThread.Priority = ThreadPriority.Lowest;
//Console.WriteLine($"{Thread.CurrentThread.Name} started");

//Thread thread1 = new(() => IncreaseTimer("Timer #1"));
//thread1.Priority = ThreadPriority.Highest;
//thread1.Name = "Thread1";

//Thread thread2 = new(() => DecreaseTimer("Timer #2"));
//thread2.Priority = ThreadPriority.Highest;
//thread2.Name = "Thread2";

//thread1.Start();
//Console.WriteLine($"{thread1.Name} started");

//thread2.Start();
//Console.WriteLine($"{thread2.Name} started");



//Console.WriteLine($"{Thread.CurrentThread.Name} finshed"); 
#endregion

#region LOCK
//int counter = 0;

////object counterLock = new object();
//Lock counterLock = new Lock();

//Thread thread1 = new(IncrementCounter);
//Thread thread2 = new(IncrementCounter);

//thread1.Start();
//thread2.Start();


//thread1.Join();
//thread2.Join();


//Console.WriteLine($"Final counter value is: {counter}");


//void IncrementCounter()
//{
//    for (int i = 0; i < 1000000; i++)
//    {
//        lock (counterLock)
//        {
//            //Critical Section
//            int temp = counter;
//            counter = temp + 1;
//        }
//    }
//}

#endregion




#region MONITOR
//int counter = 0;

////object counterLock = new object();
//Lock counterLock = new Lock();

//Thread thread1 = new(IncrementCounter);
//Thread thread2 = new(IncrementCounter);

//thread1.Start();
//thread2.Start();


//thread1.Join();
//thread2.Join();


//Console.WriteLine($"Final counter value is: {counter}");


//void IncrementCounter()
//{
//    for (int i = 0; i < 1000000; i++)
//    {
//        if (Monitor.TryEnter(counterLock, 2000))
//        {
//            try
//            {
//                //Critical Section
//                int temp = counter;
//                counter = temp + 1;
//            }
//            finally
//            {
//                Monitor.Exit(counterLock);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Thread is busy...");
//        }


//    }
//}

#endregion





#region MUTEX
//int counter = 0;

////object counterLock = new object();
//Lock counterLock = new Lock();

//Thread thread1 = new(IncrementCounter);
//Thread thread2 = new(IncrementCounter);

//thread1.Start();
//thread2.Start();


//thread1.Join();
//thread2.Join();


//Console.WriteLine($"Final counter value is: {counter}");


//void IncrementCounter()
//{
//    using (Mutex mutex = new(initiallyOwned: false, "IncrementMutex"))
//    {
//        for (int i = 0; i < 1000000; i++)
//        {
//            mutex.WaitOne();
//            try
//            {
//                //Critical Section
//                int temp = counter;
//                counter = temp + 1;
//            }
//            finally
//            {
//                mutex.ReleaseMutex();
//            }


//        }
//    }
//}

#endregion






//static void IncreaseTimer(string name)
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{name} {i}");
//    }
//}

//static void DecreaseTimer(string name)
//{
//    for (int i = 10 - 1; i >= 0; i--)
//    {
//        Thread.Sleep(1000);
//        Console.WriteLine($"{name} {i}");
//    }
//}

