using System.Linq;
using static System.Console;

namespace LargeNumberQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateLotsOfNumber(12045678);

            var queryRes = 
                from n in numbers
                where n < 1000
                select n;
            WriteLine("Queried numbers that are lower than 1.000");
            foreach(var item in queryRes)
            {
                WriteLine(item);
            }
        }

        private static int[] GenerateLotsOfNumber(int length)
        {
            Random random = new Random();
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                numbers[i] = random.Next(0, length);
            }
            return numbers;
        }
    }
}