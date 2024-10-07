namespace Lecture8
{
    interface IFlyer
    {
        void Fly();
    }

    public interface IBird
    {
        void Eat();
        void Drink();
    }

    public class Eagle : IBird, IFlyer
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }

    public class Penguin : IBird
    {
        public void Drink()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }
    }


    public abstract class Person
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

        public virtual string Talk() => $"Hello I am Person {FirstName} {LastName} {Age} years old.";
        public abstract void Walk();
    }
    public abstract class Employee : Person
    {
        public double Salary { get; set; }

        //public new int Age { get; set; } გადაფარვა

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

        public override void Walk()
        {
            Console.WriteLine("I am a Student and I walk in university");
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

        public override void Walk()
        {
            Console.WriteLine("I am a Teacher and I walk in university");
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
            //2.პოლიმორფიზმი +
            //3.ენკაფსულაცია +
            //4.აბსტრაქცია +


            //Person personObj1 = new()
            //{
            //    FirstName = "Tengiz",
            //    LastName = "Patchkoria",
            //    Age = 25
            //};
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
            //teacherObj1.Walk();

            //Student studObj1 = new()
            //{
            //    FirstName = "Saba",
            //    LastName = "Ekhvaia",
            //    Age = 20,
            //    Score = 99,
            //    Subject = new Subject() { Name = "C#" }
            //};
            //studObj1.Walk();


            //Console.WriteLine($"EMPLOYEE: {employeeObj1.Talk()}");
            //Console.WriteLine($"TEACHER: {teacherObj1.Talk()}");
            //Console.WriteLine($"STUDENT: {studObj1.Talk()}");


            //Console.WriteLine(employeeObj1.Talk());
            //Console.WriteLine(teacherObj1.Talk());
            //Console.WriteLine(studObj1.Talk());



        }


        public static void HelloFunction(Person arg)
        {
            Console.WriteLine($"Hello {arg.FirstName} {arg.LastName}");
        }
    }
}
