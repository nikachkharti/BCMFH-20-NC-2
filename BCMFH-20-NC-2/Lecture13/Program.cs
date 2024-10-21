namespace Lecture13
{
    public delegate void LoggingDelegate(string text);

    internal class Program
    {

        static void Main(string[] args)
        {
            //დაწერეეთ ლოგერი ლოგერი (ფუნქცია)
            //უნდა იღებდეს რაღაც ტექსტს და დელეგატს რომელზეც შემეძლება
            //ფუნქციის მიცემა თუ სად მსურს გადაცემული ტექსტის დალოგვა, ფაილში თუ კონსოლში

            Logger("Hello World", x => File.WriteAllText("../../../DelegateLogger.txt", x));

        }


        public static void Logger(string message, LoggingDelegate loggingDelegate)
        {
            loggingDelegate(message);
        }

        public static void WriteInConsole(string messageText)
        {
            Console.WriteLine(messageText);
        }


        public static void WriteInFile(string messageText)
        {
            File.WriteAllText(@"../../../DelegateLogger.txt", messageText);
        }


    }
}
