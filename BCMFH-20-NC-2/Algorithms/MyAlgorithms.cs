using Algorithms.Models;

namespace Algorithms
{
    public class MyAlgorithms
    {
        public static int FirstOrDefault(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return value;
                }
            }

            return default;
        }
        public static int FirstOrDefault(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    return value;
                }
            }

            return default;
        }
        public static int LastOrDefault(List<int> collection, int value)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return value;
                }
            }

            return default;
        }
        public static int LastOrDefault(int[] collection, int value)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return value;
                }
            }

            return default;
        }
        public static List<int> Where(List<int> collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (value == collection[i])
                {
                    result.Add(value);
                }
            }

            return result;
        }
        public static int[] Where(int[] collection, int value)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (value == collection[i])
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }
        public static List<Vehicle> Where(Vehicle[] vehicleArray)
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
        public static int IndexOf(int[] collection, int value)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf(List<int> collection, int value)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf(int[] collection, int value)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (collection[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int Sum(int[] collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                result += collection[i];
            }

            return result;
        }
        public static int Sum(List<int> collection)
        {
            int result = 0;

            for (int i = 0; i < collection.Count; i++)
            {
                result += collection[i];
            }

            return result;
        }
        public static Vehicle[] Select(string[] carsArray)
        {
            Vehicle[] vehicleArray = new Vehicle[carsArray.Length];

            for (int i = 0; i < carsArray.Length; i++)
            {
                vehicleArray[i] = Vehicle.Parse(carsArray[i]);
            }

            return vehicleArray;
        }
        public static Vehicle[] OrderBy(Vehicle[] vehicleArray)
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


    }
}
