using Algorithms.Models;
using System.Collections;

//დელეგატი

namespace Algorithms
{
    #region ჯენერიკ დელეგატები

    //Action -- არის დელეგატი რომელიც მუშაობს void ტიპის ფუნქციებთან


    //Func --> არის დელეგატი რომელიც მიინიჭებს ისეთ ფუნქციას რომელსაც მისაღებ და
    //დასაბრუნებელ ტიპსაც ჩვენ ვუდგნეთ


    //Predicate --> არის დელეგატი რომელიც მიინიჭებს ისეთ ფუნქციას რომელსაც მისაღებ
    //პარამეტრს ვუდგენთ ჩვენ, ხოლო დასაბრუნებელი
    //პარამეტრი აუცილებლად არის bool



    #endregion


    public class MyAlgorithms
    {
        public static T FirstOrDefault<T>(List<T> collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static T FirstOrDefault<T>(T[] collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static T LastOrDefault<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }
        public static T LastOrDefault<T>(T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return collection[i];
                }
            }

            return default;
        }


        public static List<T> Where<T>(List<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new();

            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }
            return result;
        }
        public static T[] Where<T>(T[] collection, Func<T, bool> predicate)
        {
            List<T> result = new();

            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    result.Add(collection[i]);
                }
            }

            return result.ToArray();
        }

        public static int IndexOf<T>(T[] collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int IndexOf<T>(List<T> collection, Predicate<T> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }


        public static int LastIndexOf<T>(List<T> collection, Func<T, bool> predicate)
        {
            for (int i = collection.Count - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int LastIndexOf<T>(T[] collection, Func<T, bool> predicate)
        {
            for (int i = collection.Length - 1; i >= 0; i--)
            {
                if (predicate(collection[i]))
                {
                    return i;
                }
            }

            return -1;
        }

        public static TResult[] Select<TSource, TResult>(TSource[] array, Func<TSource, TResult> selector)
        {
            TResult[] result = new TResult[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = selector(array[i]);
            }

            return result;
        }

        public static T[] OrderBy<T>(T[] result, Func<T, T, bool> compareFunction)
        {
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (compareFunction(result[j], result[i]))
                    {
                        T temp = result[j];
                        result[j] = result[i];
                        result[i] = temp;
                    }
                }
            }

            return result;
        }



        //public static T[] OrderBy<T>(T[] result) where T : IComparable<T>
        //{
        //    for (int i = 0; i < result.Length - 1; i++)
        //    {
        //        for (int j = i + 1; j < result.Length; j++)
        //        {
        //            if (result[j].CompareTo(result[i]) == -1)
        //            {
        //                T temp = result[j];
        //                result[j] = result[i];
        //                result[i] = temp;
        //            }
        //        }
        //    }

        //    return result;
        //}





        /*














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



         */
    }
}
