namespace Lecture10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] newList = { 5, 4, 3 };

            List<int> intList = new List<int>();
            intList.Add(72);
            intList.Add(33);
            intList.Add(6);
            intList.Add(899);
            intList.Add(1);
            //intList.AddRange(newList);
            intList.TrimExcess();
            intList.Sort();


            Console.WriteLine($"COUNT: {intList.Count}");
            Console.WriteLine($"CAPACITY: {intList.Capacity}");




        }

    }
}
