
//Single responsibility
//Encapsulation - ენკაფსულაცია. გარკვეული ფუნქციონლის დაფარვა მისივე უსაფრთხოების მიზნით.

using Lecture7.Minibank.Models;

namespace Lecture7
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18)
                {
                    age = value;
                }
            }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains('@') && value.Contains('.'))
                {
                    email = value;
                }
            }
        }
    }
    public class Person // კლასი აღიწერება როგორი იყოს ობიექტი
    {
        //AUTO PROPERTY
        public string FirstName { get; set; }
        public string LastName { get; set; }


        //FULL PROPERTY
        private int age;
        public int Age
        {
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
            get
            {
                return this.age;
            }
        }




        //public void SetAge(int value)
        //{
        //    if (value > 0)
        //    {
        //        this.age = value;
        //    }
        //}

        //public int GetAge()
        //{
        //    return this.age;
        //}





        //public void Talk()
        //{
        //    Console.WriteLine($"Hello I am {firstName} {lastName} {age} years old");
        //}
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client()
            {
                FirstName = "Mikheil",
                LastName = "Nikoleishvili",
                PersonalNumber = "12345678901",
                Account = new Account()
                {
                    AccountNumber = "1234567890112345678901",
                    Balance = 500,
                    Currency = "GEL"
                }
            };


            Account client2Account = new();
            client2Account.AccountNumber = "1234567891212345678912";
            client2Account.Balance = 1000;
            client2Account.Currency = "GEL";

            Client client2 = new();
            client2.FirstName = "Mariam";
            client2.LastName = "Natchkebia";
            client2.PersonalNumber = "12345678912";
            client2.Account = client2Account;


            Console.WriteLine(client1);
            Console.WriteLine(client2);

            client1.Account.Transfer(client2.Account, 600);

            Console.WriteLine("-------------------------");

            Console.WriteLine(client1);
            Console.WriteLine(client2);

            // ობიექტი რომელიც შექმნილია Person კლასის მაგალითზე
            //Person firstPersonObject = new Person();


            //1. წერტილებით
            //Person mariamObject = new Person();
            //mariamObject.firstName = "Mariam";
            //mariamObject.lastName = "Natchkebia";


            //mariamObject.Age = 20;

            //Console.WriteLine(mariamObject.Age);




            /*

            Person ninoObject = new Person(); //კონსტრუქტორი
            ninoObject.age = 30;
            ninoObject.firstName = "Nino";
            ninoObject.lastName = "Aqiashvili";
            ninoObject.Talk();


            //2. ფროფერთის ინიციალიზატორი
            Person tengizObject = new Person() //კონსტრუქტორი
            {
                lastName = "Patchkoria",
                age = 22,
                firstName = "Tengiz",
            };

            tengizObject.Talk();


            Person ketavanObject = new Person() //კონსტრუქტორი
            {
                firstName = "Ketevan",
                lastName = "Gomiasvhili",
                age = 19
            };

            ketavanObject.Talk();

            */

        }
    }
}
