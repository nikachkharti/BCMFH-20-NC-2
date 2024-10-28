using Algorithms;
using System.Collections;

namespace Lecture15
{

    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new() { 1, 2, 3 };
            int[] intAr = { 1,10, 20, 30 };

            HashSet<int> intSet = new() { 1, 2, 3, 3, 2 };
            List<string> stringList = new() { "Nika", "Luka", "Ketevan" };

            var result = MyAlgorithms.IndexOf(intAr, x => x % 2 == 0);
        }




    }
}
