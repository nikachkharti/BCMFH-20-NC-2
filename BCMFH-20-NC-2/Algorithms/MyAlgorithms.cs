using Algorithms.Models;
using System.Collections;

//დელეგატი

namespace Algorithms
{
    public delegate bool CompareDelegate(int element);
    public delegate bool CompareDelegateVehicle(Vehicle element);
    public delegate Vehicle TransformerDelegateVehicle(string element);
    public delegate bool CompareDelegateVehicles(Vehicle v1, Vehicle v2);

    public class MyAlgorithms
    {
        public static int FirstOrDefault(List<int> collection, int value)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (value == collection[i])
                {
                    return collection[i];
                }
            }

            return default;
        }
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
        public static int FirstOrDefault(List<int> collection, CompareDelegate comparerFunction)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int FirstOrDefault(int[] collection, CompareDelegate comparerFunction)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
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
        public static int LastOrDefault(List<int> collection, CompareDelegate comparerFunction)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static int LastOrDefault(int[] collection, CompareDelegate comparerFunction)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (comparerFunction(collection[i]))
                {
                    return collection[i];
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

        public static List<int> Where(List<int> collection, CompareDelegate comparerFunction)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result;
        }
        public static int[] Where(int[] collection, CompareDelegate comparerFunction)
        {
            List<int> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (comparerFunction(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }
        public static List<Vehicle> Where(Vehicle[] vehicleArray, CompareDelegateVehicle comparerFunction)
        {
            List<Vehicle> mercedesArray = new();

            for (int i = 0; i < vehicleArray.Length; i++)
            {
                if (comparerFunction(vehicleArray[i]))
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
        public static Vehicle[] Select(string[] carsArray, TransformerDelegateVehicle transformer)
        {
            Vehicle[] vehicleArray = new Vehicle[carsArray.Length];

            for (int i = 0; i < carsArray.Length; i++)
            {
                vehicleArray[i] = transformer(carsArray[i]);
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
        public static Vehicle[] OrderBy(Vehicle[] vehicleArray, CompareDelegateVehicles compareFunction)
        {
            for (int i = 0; i < vehicleArray.Length - 1; i++)
            {
                for (int j = i + 1; j < vehicleArray.Length; j++)
                {
                    if (compareFunction(vehicleArray[j], vehicleArray[i]))
                    {
                        Vehicle temp = vehicleArray[j];
                        vehicleArray[j] = vehicleArray[i];
                        vehicleArray[i] = temp;
                    }
                }
            }

            return vehicleArray;
        }


        public static List<int> Distinct(List<int> collection)
        {
            HashSet<int> set = new();

            for (int i = 0; i < collection.Count; i++)
            {
                set.Add(collection[i]);
            }

            return set.ToList();
        }
        public static int[] Distinct(int[] collection)
        {
            HashSet<int> set = new();

            for (int i = 0; i < collection.Length; i++)
            {
                set.Add(collection[i]);
            }

            return set.ToArray();
        }
        public static List<int> Reverse(List<int> intList)
        {
            Stack<int> stack = new();

            for (int i = 0; i < intList.Count; i++)
            {
                stack.Push(intList[i]);
            }

            return stack.ToList();
        }
        public static int[] Reverse(int[] intArray)
        {
            Stack<int> stack = new();

            for (int i = 0; i < intArray.Length; i++)
            {
                stack.Push(intArray[i]);
            }

            return stack.ToArray();
        }
        public static int Max(int[] intArray)
        {
            int max = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }

            return max;
        }
        public static int Max(List<int> intList)
        {
            int max = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] > max)
                {
                    max = intList[i];
                }
            }

            return max;
        }
        public static int Min(int[] intArray)
        {
            int min = intArray[0];

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < min)
                {
                    min = intArray[i];
                }
            }

            return min;
        }
        public static int Min(List<int> intList)
        {
            int min = intList[0];

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] < min)
                {
                    min = intList[i];
                }
            }

            return min;
        }
        public static bool Any(int[] intArray, int element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] == element)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool Any(List<int> intList, int element)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == element)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool All(int[] intArray, int element)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] != element)
                {
                    return false;
                }
            }

            return true;
        }
        public static bool All(List<int> intList, int element)
        {
            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] != element)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
