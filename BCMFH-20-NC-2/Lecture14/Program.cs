using Algorithms;
using Algorithms.Models;

#region ჯენერიკ დელეგატები

//Action -- არის დელეგატი რომელიც მუშაობს void ტიპის ფუნქციებთან


//Func --> არის დელეგატი რომელიც მიინიჭებს ისეთ ფუნქციას რომელსაც მისაღებ და
//დასაბრუნებელ ტიპსაც ჩვენ ვუდგნეთ


//Predicate --> არის დელეგატი რომელიც მიინიჭებს ისეთ ფუნქციას რომელსაც მისაღებ
//პარამეტრს ვუდგენთ ჩვენ, ხოლო დასაბრუნებელი
//პარამეტრი აუცილებლად არის bool



#endregion


namespace Lecture14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> names = new() { "Tengizi", "Ilia", "Giorgi" };
            //List<int> numbers = new() { 31, 11, 12 };

            //var x = MyAlgorithms.LastOrDefault(numbers, x => x > 10);

            //string[] carsAsText = File.ReadAllLines("C:\\Users\\User\\Desktop\\IT STEP\\BCMFH-20-NC-2\\BCMFH-20-NC-2\\Lecture11\\vehicles.csv");
            //Vehicle[] cars = MyAlgorithms.Select(carsAsText, Vehicle.Parse);

            //string[] numbersAsText = { "11", "2", "3", "-1", "-2" };
            //int[] numbers = MyAlgorithms.Select(numbersAsText, int.Parse);

            //var sortedResult = MyAlgorithms.OrderBy(numbers, (x, y) => x < 0);


            GenericClass<int> test1 = new(1);
            GenericClass<int> test2 = new(2);
            GenericClass<int> test3 = new(3);

            GenericClass<string> test4 = new("A1");
            GenericClass<string> test5 = new("A2");
            GenericClass<string> test6 = new("A3");

        }
    }
}
