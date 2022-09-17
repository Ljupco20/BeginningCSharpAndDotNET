﻿using System;

namespace ExchangingData
{
    internal class Program
    {
        /// <summary>
        /// Shows the double.
        /// </summary>
        /// <param name="val">The value.</param>

        static int val;
        static void ShowDouble(ref int val)
        {
            val *= 2;
            Console.WriteLine($"val doubled = {val}");
        }
        static void Main(string[] args)
        {
            val = 5;
            Console.WriteLine($"val = {val}");
            ShowDouble(ref val);
            Console.WriteLine($"val = {val}");
        }
    }
}
