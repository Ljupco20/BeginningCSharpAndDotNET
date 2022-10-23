using System.Linq;
using static System.Console;

namespace HW_16_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = GenerateLotsOfNumbers(12500500);
            var queryResults =
                from n in numbers
                where n > 1000
                orderby n
                select n;
            WriteLine("Numbers greater than 1.000: ");

            WriteLine("Count of Numbers > 1000");
            WriteLine(queryResults.Count());

            WriteLine("Max of Numbers > 1000");
            WriteLine(queryResults.Max());

            WriteLine("Min of Numbers > 1000");
            WriteLine(queryResults.Min());

            WriteLine("Average of Numbers > 1000");
            WriteLine(queryResults.Average());

            WriteLine("Sum of Numbers > 1000");
            WriteLine(queryResults.Sum(n => (long)n));



            Write("Program finished, press Enter/Return to continue:");
        }
        static int[] GenerateLotsOfNumbers(int count)
        {
            Random generator = new Random();
            int[] result = new int[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = generator.Next();
            }
            WriteLine($"The count is {count}");
            return result;
        }

        //Very large subsets such as n > 1000 instead of n < 1000 are very slow:
    }
}