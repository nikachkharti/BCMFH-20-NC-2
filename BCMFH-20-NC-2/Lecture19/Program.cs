using System.Text;

namespace Lecture19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"../../../UnmanagedFile.txt";
            const string textToWrite = "Hello World!";

            //try
            //{
            //    using (StreamWriter sw = new StreamWriter(path, true))
            //    {
            //        sw.WriteLine(textToWrite);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //try
            //{
            //    using (StreamReader sr = new(path))
            //    {
            //        string text = sr.ReadToEnd();
            //        Console.WriteLine(text);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //ფაილში ჩაწერა FileStream საშუალებით
            //try
            //{
            //    using (FileStream fileSw = new(path, FileMode.Append, FileAccess.Write))
            //    {
            //        byte[] data = Encoding.UTF8.GetBytes(textToWrite);
            //        fileSw.Write(data);
            //        Console.WriteLine("Data is written");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //ფაილიდან ამოკითხვა FileStream საშუალებით
            //try
            //{
            //    using (FileStream fsRead = new(path, FileMode.Open, FileAccess.Read))
            //    {
            //        byte[] data = new byte[fsRead.Length];
            //        int bytesRead = fsRead.Read(data, 0, data.Length);
            //        string fileContent = Encoding.UTF8.GetString(data, 0, bytesRead);
            //        Console.WriteLine(fileContent);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




        }
    }
}
