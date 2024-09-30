using System.Net.Http.Headers;

namespace Lecture7
{
    public class Person // კლასი აღიწერება როგორი იყოს ობიექტი
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public Person()
        {
        }


        public void Talk()
        {
            Console.WriteLine($"Hello I am {firstName} {lastName} {age} years old");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // ობიექტი რომელიც შექმნილია Person კლასის მაგალითზე
            //Person firstPersonObject = new Person();





            //1. წერტილებით
            Person mariamObject = new Person("Mariam", "Natchkebia", 20); //კონსტრუქტორი
            //mariamObject.firstName = "Mariam";
            //mariamObject.lastName = "Natchkebia";
            //mariamObject.age = 20;
            mariamObject.Talk();








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


        }
    }
}
