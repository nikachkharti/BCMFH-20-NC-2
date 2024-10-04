namespace Lecture8
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    public class Employee : Person
    {
        public double Salary { get; set; }
    }

    public class Student : Person
    {
        public double Score { get; set; }
        public Subject Subject { get; set; } //კომპოზიცია
    }

    public class Teacher : Employee
    {
        public Subject Subject { get; set; } //კომპოზიცია
    }


    public class Subject
    {
        public string Name { get; set; }
    }


    internal class Program
    {
        static void Main()
        {
            //1.მემკვიდრეობა

            Teacher teacherObj1 = new()
            {
                FirstName = "Nika",
                LastName = "Chkhartishvili",
                Age = 29,
                Salary = 500,
                Subject = new Subject() { Name = "C#" }
            };
            Student studObj1 = new()
            {
                FirstName = "Saba",
                LastName = "Ekhvaia",
                Age = 20,
                Score = 99,
                Subject = new Subject() { Name = "C#" }
            };


            HelloFunction(teacherObj1);



            //2.პოლიმორფიზმი
            //3.ენკაფსულაცია
            //4.აბსტრაქცია
        }


        public static void HelloFunction(Person arg)
        {
            Console.WriteLine($"Hello {arg.FirstName} {arg.LastName}");
        }
    }
}
