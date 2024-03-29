﻿using static System.Console;


int[] numbers = GenerateLotsOfNumbers(12345678);
WriteLine("Numeric Aggregates");
var queryResults = 
    from n in numbers
    where n > 1000
    select n;

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

static int[] GenerateLotsOfNumbers(int count)
{
    Random generator = new Random(0);
    int[] result = new int[count];
    for (int i = 0; i < count; i++)
    {
        result[i] = generator.Next();
    }
    return result;
}