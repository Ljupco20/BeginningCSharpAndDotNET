using System.Linq;
using static System.Console;

namespace HW_16_6
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
                foreach (var item in queryResults)
                {
                    WriteLine(item);
                }
                Write("Program finished, press Enter/Return to continue:");


            //WriteLine("Aggregate Operators for strings? Count():");
            //WriteLine(queryResults.Count());

            WriteLine("Aggregate Operators for strings? Min():");
            WriteLine(queryResults.Max());

            WriteLine("Aggregate Operators for strings? Max():");
            WriteLine(queryResults.Min());

            // only Min() and Max() are available (if no lambda is used)
            // for a result set like this consisting only of strings
        }
    }
}