using MiniBank.Models;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lecture21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //Type studentType = s1.GetType();
            //MethodInfo[] methods = studentType.GetMethods();
            //PropertyInfo[] properties = studentType.GetProperties();

            //foreach (var method in methods)
            //{
            //    Console.WriteLine(method);
            //}


            //DtoGenerator.GenerateDto(typeof(Account), @"C:\Users\User\Desktop\BCMFH-20-NC-2\BCMFH-20-NC-2\Lecture21\Dtos\");


            Student student1 = new();
            student1.FirstName = "Luka";
            student1.StartDate = DateTime.Now;
            student1.EndDate = DateTime.Now.AddDays(1);

            ValidationContext validationContext = new(student1);
            List<ValidationResult> results = new();

            bool isValid = Validator.TryValidateObject(student1, validationContext, results, true);

            if (!isValid)
            {
                foreach (var item in results)
                {
                    Console.WriteLine(item.ErrorMessage);
                }
            }
        }

    }
}
