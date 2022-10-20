using System.Linq;
using static System.Console;
namespace BeginningCSharpAndDotNET_16_4_QueringPersonObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
            {
                    new Person() { FirstName = "Alonso", LastName = "Sherman", Age = 23},
                    new Person() { FirstName = "Smith", LastName = "Howells", Age = 16},
                    new Person() { FirstName = "Smythe", LastName = "Warner", Age = 32},
                    new Person() { FirstName = "Ilyich", LastName = "King", Age = 64},
                    new Person() { FirstName = "Jones", LastName = "Bright", Age = 26},
                    new Person() { FirstName = "Smith", LastName = "Walton", Age = 45},
                    new Person() { FirstName = "Samba", LastName = "Warren", Age = 25},
                    new Person() { FirstName = "Singh", LastName = "Flynn", Age = 18},
                    new Person() { FirstName = "Fatimah", LastName = "Torres", Age = 10},
                    new Person() { FirstName = "Zheng", LastName = "Chen", Age = 53},
                    new Person() { FirstName = "Ruiz", LastName = "Flowers", Age = 33},
                    new Person() { FirstName = "Jorgenson", LastName = "Frank", Age = 37},
                    new Person() { FirstName = "Hsieh", LastName = "Howells", Age = 21}
            };

            //LINQ query for filtering data

            //Query syntax
            var queryResult =
                from p in people
                where p.LastName.StartsWith("F")
                select p;

            var queryResult2 =
                from p in people
                where p.Age >= 21
                select p;


            //Method syntax
            var methodResult = people.Where(p => p.LastName.StartsWith("F"));
            var methodResult2 = people.Where(p => p.Age >= 21);



            WriteLine("Names beginning with F:");
            foreach (var item in queryResult)
            {
                WriteLine($"{item.LastName} {item.LastName} has age of {item.Age}");
            }
            Write("Program finished, press Enter/Return to continue:");

            WriteLine("People older than 20:");
            foreach (var item in queryResult2)
            {
                WriteLine($"{item.LastName} {item.LastName} has age of {item.Age}");
            }
            Write("Program finished, press Enter/Return to continue:");
        }
    }
}