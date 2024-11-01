using Algorithms;

namespace Lecture16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ  Language Integrate Queries

            //1.Extension მეთოდები
            //2.LINQ Query

            List<string> stringList = new() { "12", "21", "3" };

            var result = stringList
                .MySelect(int.Parse)
                .MyWhere(x => x % 2 != 0)
                .ToList()
                .MyOrderBy((x, y) => x < y)
                .MyFirstOrDefault(x => x % 2 != 0);

            //var intList = MyAlgorithms.Select(stringList, int.Parse);
            //var intOdds = MyAlgorithms.Where(intList, x => x % 2 != 0).ToList();
            //var sortedOdds = MyAlgorithms.OrderBy(intOdds, (x, y) => x < y);
            //var firstOddElement = MyAlgorithms.FirstOrDefault(sortedOdds, x => x % 2 != 0);


            //var res = stringList
            //    .Select(int.Parse)
            //    .Where(x => x % 2 != 0)
            //    .OrderBy(x => x)
            //    .FirstOrDefault(x => x % 2 != 0);

        }
    }
}
