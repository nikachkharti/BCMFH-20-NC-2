using Algorithms;
using Algorithms.Models;

namespace Lecture11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.ამ ფაილის მიხედვით შექმნათ მანქანის კლასი
            //2.ამ კლასის მიხედვით უნდა შექმნათ მანქანის ობიექტი
            //3.ფაილიდან შეძლოთ ერთი ობიექტის შესახებ ინფორმაციის გარდაქმნა და მისი ობიექტად ქცევა



            //მიბრუნებს string ს
            //string longText = File.ReadAllText("C:\\Users\\User\\Desktop\\IT STEP\\BCMFH-20-NC-2\\BCMFH-20-NC-2\\Lecture11\\vehicles.csv");

            //მიბრუნებს string ის მასივს 

            string[] carsArray = File.ReadAllLines("../../../vehicles.csv");

            var vehicles = MyAlgorithms.Select(carsArray);
            MyAlgorithms.OrderBy(vehicles);
            MyAlgorithms.Where(vehicles);

        }







    }
}
