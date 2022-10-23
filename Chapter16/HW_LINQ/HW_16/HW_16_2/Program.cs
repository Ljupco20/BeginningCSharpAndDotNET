
using System.Linq;
using static System.Console;

int[] numbers = GenerateLotsOfNumbers(100000);
var queryResults =
    from n in numbers
    where n > 1000 && n < 50000
   
    select n;
WriteLine("Numbers between 1.000 and 50.000:");

foreach (var item in queryResults)
{
    WriteLine(item);
}
Write("Program finished, press Enter/Return to continue:");

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



int[] numbers2 = GenerateNumbers(100);
var queryResults2  =
    from n in numbers2

    select n;
WriteLine("Numbers are:");

foreach (var item in queryResults2)
{
    WriteLine(item);
}
Write("Program finished, press Enter/Return to continue:");


static int[] GenerateNumbers(int count)
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