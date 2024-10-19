using Algorithms;

namespace Lecture12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ARRAY LIST
            //int[] intAr = new int[2];
            List<int> intList = new();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(3);

            //List<int> x =  intList.Distinct().ToList();


            #region STACK - LIFO Last In First Out

            //Stack<int> intStack = new();
            //intStack.Push(1);
            //intStack.Push(2);
            //intStack.Push(3);

            //intStack.Pop();
            //var x = intStack.Peek();


            #endregion


            #region HASHSET

            //HashSet<int> intSet = new();
            //intSet.Add(1);
            //intSet.Add(2);
            //intSet.Add(3);

            //HashSet<int> intSet2 = new();
            //intSet2.Add(4);
            //intSet2.Add(5);
            //intSet2.Add(5);
            //intSet2.Add(5);
            //intSet2.Add(6);
            //intSet2.Add(3);

            //var x = intSet2.IsSubsetOf(intSet);
            //var x2 = intSet2.IsSupersetOf(intSet);

            //var unitedSets = intSet.Union(intSet2); // გაერითანება
            //var commonElements = intSet.Intersect(intSet2); // საერთო ელემენტები


            #endregion


            #region QUEUE - FIFO First In First Out

            //Queue<int> intQueue = new();
            //intQueue.Enqueue(1);
            //intQueue.Enqueue(2);
            //intQueue.Enqueue(3);

            //intQueue.Dequeue();
            //intQueue.Dequeue();
            //intQueue.Dequeue();

            #endregion


            #region DICTIONARY

            //Dictionary<string, int> names = new();
            //names.Add("One", 1);
            //names.Add("Two", 2);
            //names.Add("Three", 3);

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"{name.Key} {name.Value}");
            //}

            //var x = CountWords("me var nika me var programisti");


            #endregion
        }

        //public static Dictionary<string, int> CountWords(string sentence)
        //{
        //    Dictionary<string, int> result = new();
        //    var words = sentence.Split(' ');

        //    foreach (var word in words)
        //    {
        //        var rawWord = word.Trim().ToLower();

        //        if (result.ContainsKey(rawWord))
        //        {
        //            result[word] += 1;
        //        }
        //        else
        //        {
        //            result.Add(rawWord, 1);
        //        }
        //    }

        //    return result;
        //}

    }
}
