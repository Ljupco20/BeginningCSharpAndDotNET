using System.Linq;
using static System.Console;

namespace HW_16_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Alonso", "Zheng", "Smith", "Jones", "Smythe", "Small",
"Ruiz", "Hsieh", "Jorgenson", "Ilyich", "Singh", "Samba", "Fatimah" };

            var queryResults = names;

            WriteLine("It returns all the names when the Where Method is not inserted:");
            foreach (var item in queryResults)
            {
                WriteLine(item);
            }
            Write("Program finished, press Enter/Return to continue:");

            //Asnwer to Question 16.5
            //It returns all the names when the Where Method is not inserted
            //There is no query

        }
    }
}