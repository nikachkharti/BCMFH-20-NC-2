using Lecture11.Models;

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

            var vehicles = Select(carsArray);
            OrderBy(vehicles);
            Where(vehicles);

        }

        private static Vehicle[] Select(string[] carsArray)
        {
            Vehicle[] vehicleArray = new Vehicle[carsArray.Length];

            for (int i = 0; i < carsArray.Length; i++)
            {
                vehicleArray[i] = Vehicle.Parse(carsArray[i]);
            }

            return vehicleArray;
        }
        private static Vehicle[] OrderBy(Vehicle[] vehicleArray)
        {
            for (int i = 0; i < vehicleArray.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicleArray.Length; j++)
                {
                    if (vehicleArray[j].Combined > vehicleArray[i].Combined)
                    {
                        Vehicle temp = vehicleArray[j];
                        vehicleArray[j] = vehicleArray[i];
                        vehicleArray[i] = temp;
                    }
                }
            }

            return vehicleArray;
        }
        private static List<Vehicle> Where(Vehicle[] vehicleArray)
        {
            List<Vehicle> mercedesArray = new();

            for (int i = 0; i < vehicleArray.Length; i++)
            {
                if (vehicleArray[i].Make.Contains("Mercedes", StringComparison.OrdinalIgnoreCase))
                {
                    mercedesArray.Add(vehicleArray[i]);
                }
            }

            return mercedesArray;
        }





    }
}
