using System;

namespace Homework_Operants
{
    internal class Program
    {

        static void AddTwoNum(int num1, int num2)
        {
            Console.WriteLine($"{num1 + num2}");
        }
        static void DivideTwoNum(int num1, int num2)
        {
            Console.WriteLine($"{num1 / num2}");
        }
        static void Calculations()
        {
            Console.WriteLine($"{-1 + 4 * 6}");
            Console.WriteLine($"{(35 + 5) % 7}");
            Console.WriteLine($"{14 + -4 * 6 / 11}");
            Console.WriteLine($"{2 + 15 / 6 * 1 - 7 % 2}");
        }
        static void SwapTwoNums()
        {
            Console.WriteLine("Please enter first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number");
            int num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"first number is {num2}, second number is {num1}");

        }

        static void MultipleThreeNum()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num3 = Int32.Parse(Console.ReadLine());
            int res = num1 * num2 * num3;
            Console.WriteLine($"{num1} x {num2} x {num3} = {res}");
        }
        static void MultipleCalc()
        {
            int num1 = 25;
            int num2 = 4;
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
        }
        static void MultiplicationTable(int num)
        {
            for (int i = 0; i <= 10; i++)
            {
                int res = num * i;
                Console.WriteLine($"{num} * {i} = {res}");
            }
        }
        static void CalcAverage()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number");
            int num4 = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"The average of {num1} , {num2} , {num3} , {num4} is: {(num1+ num2+ num3+ num4)/4}");


        }
        static void Calcs()
        {
            int num1 = 5;
            int num2 = 6;
            int num3 = 7;
            Console.WriteLine($"Result of specified numbers {num1}, {num2}, {num3}, (x+y)*z is {(num1+ num2)* num3} and x*y + y*z is {(num1 * num2 + num2 * num3)}");
        }
        static void Age()
        {
            Console.WriteLine("Please enter your age");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine($"You look older than {age}");
        }
        static void DisplayFourTime()
        {
            Console.WriteLine("Please enter a number");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
            Console.WriteLine("{0} {0} {0} {0}", num);
            Console.WriteLine("{0}{0}{0}{0}", num);
        }
        static void DisplaysRectangle()
        {
            Console.WriteLine("Please enter a number");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(
                $"{num}{num}{num}\n{num} {num}\n{num} {num}\n{num} {num}\n{num}{num}{num}");
        }
        static void Transformtemperature()
        {
            Console.WriteLine($"Enter the amount of Celsius: ");
            double tempCel = double.Parse(Console.ReadLine());

            double tempFahrenheit = (9.00/5.00);
            Console.WriteLine($"{tempFahrenheit}");


            Console.WriteLine($"Temperature in Kelvin: {tempCel + 273.15}");
            Console.WriteLine($"Temperature in Fahrenheit: {(9.00/5.00*tempCel)+32}");
        }
        static void Main(string[] args)
        {
            AddTwoNum(5, 5);
            DivideTwoNum(10, 2);
            Calculations();
            //SwapTwoNums();
            //MultipleThreeNum();
            MultipleCalc();
            MultiplicationTable(5);
            //CalcAverage();
            Calcs();
            //Age();
            //DisplayFourTime();
            //DisplaysRectangle();
            Transformtemperature();
        }
    }
}