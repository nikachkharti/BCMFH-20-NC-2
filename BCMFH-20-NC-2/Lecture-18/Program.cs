using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft;
using Newtonsoft.Json;

namespace Lecture_18
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Hobbies { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //JSON -- Javascript Object Notation

            //List<Person> people = new List<Person>()
            //{
            //    new Person()
            //    {
            //        Id = 1,
            //        Name = "Alice",
            //        Age = 30,
            //        Hobbies = new List<string>()
            //        {
            //            "Reading Boooks",
            //            "Playing football"
            //        }
            //    },
            //    new Person()
            //    {
            //        Id = 2,
            //        Name = "Bob",
            //        Age = 16,
            //        Hobbies = new List<string>()
            //        {
            //            "Gaming",
            //            "Playing guitar"
            //        }
            //    }
            //};




            //სერიალიზაცია
            //string jsonString = JsonSerializer.Serialize(people, new JsonSerializerOptions()
            //{
            //    WriteIndented = true
            //});

            //File.WriteAllText(@"../../../PeopleAsJson.json", jsonString);

            //Newtonsoft
            //string jsonString = JsonConvert.SerializeObject(people, Formatting.Indented);
            //File.WriteAllText(@"../../../PeopleAsJson.json", jsonString);


            //დესერიალიზაცია
            //string text = File.ReadAllText(@"../../../PeopleAsJson.json");
            //List<Person> peopleList = JsonSerializer.Deserialize<List<Person>>(text);


            //Newtonsoft
            //string text = File.ReadAllText(@"../../../PeopleAsJson.json");
            //List<Person> peopleList = JsonConvert.DeserializeObject<List<Person>>(text);

        }

    }
}
