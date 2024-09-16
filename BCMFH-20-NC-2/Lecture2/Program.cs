namespace Lecture2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //არითმეტიკული ოპერატორები + - * / %
            //int x = 1;
            //int y = 2;

            // ++ -- += -= *= /=


            //Console.WriteLine(x+y);


            //string name = "Ilia";
            //string lastName = "Metreveli";

            ////IMPLICIT ტიპიზიცაია
            //byte y = 5;
            //int x = y;


            //EXPLICIT ტიპიზიცაია
            //int y = 600;
            //byte x = checked((byte)y);
            //Console.WriteLine($"X: {x} Y: {y}");


            //Console.WriteLine("Hello" + " " + name);
            //Console.WriteLine($"Hello {name} {lastName}");
            //Console.WriteLine("Hello {1} {0}", name, lastName);


            //ლოგიკური ოპერატორები
            // > < >= <= == !=

            //Console.WriteLine(5 > 8); // false
            //Console.WriteLine(18 >= 8); // True
            //Console.WriteLine(1 <= 8); // True
            //Console.WriteLine(8 == 8); //True
            //Console.WriteLine(8 != 8);// False
            //Console.WriteLine(!true);

            //IF SWITCH

            //int x = 20;
            //int y = 10;

            //if (x > y)
            //{
            //    x *= 2;
            //    Console.WriteLine(x);
            //}
            //else if (x == y)
            //{
            //    Console.WriteLine(x + y);
            //}
            //else
            //{
            //    Console.WriteLine(y);
            //}


            //1. მომხმარებელს სთხოვეთ შემოიყვანოს სახლი გვარი ასაკი
            // გამარჯობა მე მქვია {სახელი} {გვარი} ვარ {ასაკი} წლის

            //Console.Write("FIRSTNAME: ");
            //string firstName = Console.ReadLine();

            //Console.Write("LASTNAME: ");
            //string lastName = Console.ReadLine();

            //Console.Write("AGE: ");
            //int age = int.Parse(Console.ReadLine());
            ////int age = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"Hello my name is {firstName} {lastName}. I am {age} years old");


            //int number = 5;

            //if (number == 5 || number == 7)
            //{
            //    Console.WriteLine("5 OR 7");
            //}
            //else if (number > 10)
            //{
            //    Console.WriteLine("10");
            //}
            //else if (number == 12)
            //{
            //    Console.WriteLine("12");
            //}
            //else
            //{
            //    Console.WriteLine("ERROR");
            //}


            //switch (number)
            //{
            //    case int x when x > 10:
            //        Console.WriteLine("METIA 10-ZE ");
            //        break;
            //    case 10:
            //        Console.WriteLine("NUMBER IS 10");
            //        break;
            //    case 12:
            //        Console.WriteLine("NUMBER IS 12");
            //        break;
            //    default:
            //        Console.WriteLine("ERROR");
            //        break;
            //}



            int.TryParse("dasd", out int x);

            Console.WriteLine(x);

        }
    }
}
