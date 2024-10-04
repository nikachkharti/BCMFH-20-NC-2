namespace Lecture8
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person()
        {
        }

        public virtual string Talk()
        {
            return $"Hello I am Person {FirstName} {LastName} {Age} years old.";
        }
    }

    public class Employee : Person
    {
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age)
        {
            Salary = salary;
        }

        public Employee()
        {
        }

        public override string Talk()
        {
            return $"Hello I am Employee {FirstName} {LastName} {Age} years old, salary {Salary} GEL";
        }
    }

    public class Student : Person
    {
        public double Score { get; set; }
        public Subject Subject { get; set; } //კომპოზიცია

        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }

        public Student()
        {
        }

        public override string Talk()
        {
            return $"Hello I am Student {FirstName} {LastName} {Age} years old, score {Score} , Subject {Subject.Name}";
        }
    }

    public class Teacher : Employee
    {
        public Subject Subject { get; set; } //კომპოზიცია

        public Teacher(string firstName, string lastName, int age, double salary) : base(firstName, lastName, age, salary)
        {
        }

        public Teacher()
        {
        }

        public override string Talk()
        {
            return $"Hello I am Teacher {FirstName} {LastName} {Age} years old, salary {Salary} GEL , Subject {Subject.Name}";
        }
    }


    public class Subject
    {
        public string Name { get; set; }
    }


    internal class Program
    {
        static void Main()
        {
            //1.მემკვიდრეობა +

            //Employee employeeObj1 = new()
            //{
            //    FirstName = "Giorgi",
            //    LastName = "Giorgadze",
            //    Age = 15,
            //    Salary = 1000
            //};
            //Teacher teacherObj1 = new()
            //{
            //    FirstName = "Nika",
            //    LastName = "Chkhartishvili",
            //    Age = 29,
            //    Salary = 500,
            //    Subject = new Subject() { Name = "C#" }
            //};
            //Student studObj1 = new()
            //{
            //    FirstName = "Saba",
            //    LastName = "Ekhvaia",
            //    Age = 20,
            //    Score = 99,
            //    Subject = new Subject() { Name = "C#" }
            //};

            //Console.WriteLine($"EMPLOYEE: {employeeObj1.Talk()}");
            //Console.WriteLine($"TEACHER: {teacherObj1.Talk()}");
            //Console.WriteLine($"STUDENT: {studObj1.Talk()}");



            //2.პოლიმორფიზმი +

            //Console.WriteLine(employeeObj1.Talk());
            //Console.WriteLine(teacherObj1.Talk());
            //Console.WriteLine(studObj1.Talk());



            //3.ენკაფსულაცია +


            //4.აბსტრაქცია
        }


        public static void HelloFunction(Person arg)
        {
            Console.WriteLine($"Hello {arg.FirstName} {arg.LastName}");
        }
    }
}
