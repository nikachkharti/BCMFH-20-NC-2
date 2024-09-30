
//Single responsibility
//Encapsulation - ენკაფსულაცია. გარკვეული ფუნქციონლის დაფარვა მისივე უსაფრთხოების მიზნით.

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
            // ობიექტი რომელიც შექმნილია Person კლასის მაგალითზე
            //Person firstPersonObject = new Person();


            //1. წერტილებით
            Person mariamObject = new Person();
            //mariamObject.firstName = "Mariam";
            //mariamObject.lastName = "Natchkebia";


            mariamObject.Age = 20;

            Console.WriteLine(mariamObject.Age);






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
