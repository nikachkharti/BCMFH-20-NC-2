using Algorithms.Models;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new() { 10, 1, 12, 2, 4, 5, 21, 71 };

            var res = MyAlgorithms.FirstOrDefault(intList, IsElementOdd);
        }

        public static bool CompareTwoVehiclesWithCombinedValue(Vehicle v1, Vehicle v2)
        {
            return v1.Combined > v2.Combined;
        }
        public static Vehicle ConvertStringToVehicleObject(string element)
        {
            return Vehicle.Parse(element);
        }
        static bool FindMercedeses(Vehicle vehicle)
        {
            if (vehicle.Make.Contains("Mercedes", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
        static bool EqualsFive(int element)
        {
            if (element == 5)
            {
                return true;
            }

            return false;
        }
        static bool EqualsTen(int element)
        {
            if (element == 10)
            {
                return true;
            }

            return false;
        }
        static bool IsElementEven(int element)
        {
            if (element % 2 == 0)
            {
                return true;
            }

            return false;
        }
        static bool IsElementOdd(int element)
        {
            if (element % 2 != 0)
            {
                return true;
            }

            return false;
        }
        static bool IsElementPositive(int element)
        {
            if (element > 0)
            {
                return true;
            }

            return false;
        }
        static bool IsElementNegative(int element)
        {
            if (element < 0)
            {
                return true;
            }

            return false;
        }
        static bool IsElementEvenSeven(int element)
        {
            if (element % 7 == 0)
            {
                return true;
            }

            return false;
        }
    }



}
