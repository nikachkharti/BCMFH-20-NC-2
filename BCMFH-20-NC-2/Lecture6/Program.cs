namespace Lecture6
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static int EvenElements(int[] collection)
        {
            int count = 0;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] % 2 == 0)
                {
                    count++;
                }
            }

            return count;
        }
        static int OddElements(int[] collection)
        {
            int count = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }

        //static Tuple<int, int> EvenAndOddElements(int[] collection)
        //{
        //    int oddCount = 0;
        //    int evenCount = 0;

        //    for (int i = 0; i < collection.Length; i++)
        //    {
        //        if (collection[i] % 2 == 0)
        //        {
        //            evenCount++;
        //        }
        //        else
        //        {
        //            oddCount++;
        //        }
        //    }

        //    return Tuple.Create<int, int>(evenCount, oddCount);
        //}
    }
}
