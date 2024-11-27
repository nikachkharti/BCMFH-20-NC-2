using System.Timers;
using Timer = System.Timers.Timer;

namespace Lecture23
{
    internal class Program
    {
        //private static Timer _timer;
        //private static bool _isWorking = true;

        static async Task Main(string[] args)
        {

            #region MyRegion
            //ThreadPool.GetMaxThreads(out int workerThreads, out int ioThreads);
            //Console.WriteLine(workerThreads);

            //try
            //{
            //    Thread t1 = new(() =>
            //    {
            //        throw new InvalidOperationException("Invalid operation");
            //    });
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //Console.WriteLine("Started Main Function....");

            //_timer = new Timer(5000); //10
            //_timer.Elapsed += StopFunction;
            //_timer.AutoReset = false;
            //_timer.Start();

            //while (_isWorking)
            //{
            //    Console.WriteLine("Main Function is working...");
            //    Thread.Sleep(1000);
            //}

            //Console.WriteLine("Stopped Main Function....");


            //Task task1 = new(Test);
            //task1.Start();

            //Task.Run(Test); 
            #endregion

            Console.WriteLine("Stated Main method...");

            var finalResult = await Calculate();

            Console.WriteLine($"Final result: {finalResult}");
            Console.WriteLine("Finished Main method...");

        }

        private static async Task<int> Calculate()
        {
            int result1 = await Calculate1();
            Console.WriteLine($"Result1: {result1}");

            int result2 = await Calculate2(result1);
            Console.WriteLine($"Result2: {result2}");

            int result3 = await Calculate3(result2);
            Console.WriteLine($"Result3: {result3}");

            return result3;
        }
        private async static Task<int> Calculate1()
        {
            await Task.Delay(1000);
            Console.WriteLine($"Calculating result1...");
            return 100;
        }
        private async static Task<int> Calculate2(int input)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Calculating result2 using input {input}...");
            return input * 2;
        }
        private async static Task<int> Calculate3(int input)
        {
            await Task.Delay(1000);
            Console.WriteLine($"Calculating result3 using input {input}...");
            return input + 50;
        }







        //private static void Test()
        //{
        //    Console.WriteLine("Test Method");
        //}

        //private static void StopFunction(object sender, ElapsedEventArgs e)
        //{
        //    Console.WriteLine("Stopping function after 10 seconds......");
        //    _isWorking = false;
        //    _timer.Stop();
        //    _timer.Dispose();
        //}
    }
}
