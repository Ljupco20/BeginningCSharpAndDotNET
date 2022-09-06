using System;

namespace Ch_04_ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0<=myInt) && (myInt<=5);
            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer is between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly on of the above is true {isLessThan10 ^ isBetween0And5}");
            
            //string myString = (isLessThan10) ? "Less than 10" : "Greater than or equal to 10";
            string myString = "My string is: ";
            myString += myInt < 10 ? "Less than 10" : "Greater than or equal to 10";

            Console.WriteLine($"The ternary operator value is {myString}");
        }
    }
}
