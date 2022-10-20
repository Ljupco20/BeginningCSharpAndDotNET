using System.Linq;
using static System.Console;

namespace BeginningCSharpAndDotNET_16_3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small", "Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            //Query syntax
            var queryResults =
                from n in names
                where n.StartsWith("S")
                select n;

            //Method syntax
            IEnumerable<string> methodQuery = names.Where(n => n.StartsWith("S")); // with Lambda expression

            WriteLine("Names beginning with S:");
            foreach(var item in queryResults)
            {
                WriteLine(item);
            }
            Write("Program finished, press Enter/Return to continue:");
            
        }
    }
}