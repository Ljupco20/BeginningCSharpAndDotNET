using System;

namespace Ch10Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating object myObj ...");
            MyClass myObj = new MyClass("My Object");
            for (int i = -1; i <= 0; i++)
            {
                try
                {
                    Console.WriteLine($"\nAttempting to assign {i} to myObj.Val...");
                    myObj.Val = i;
                    Console.WriteLine($"Value {myObj.Val} assigned to myObj.Val.");
                }
                catch (Exception e)
                {

                    Console.WriteLine($"Exception {e.GetType().FullName} throw.");
                    Console.WriteLine($"Message: \n\"{e.Message}\"");
                }
                Console.WriteLine("\nOutputting myObj.ToString()...");
                Console.WriteLine(myObj.ToString());
                Console.WriteLine("myObj.ToString() Output.");
                Console.WriteLine("\nmyDoubledInt = 5...");
                Console.WriteLine($"Getting myDoubledIntProp of 5 is {myObj.myDoubledIntProp}");
                Console.ReadKey();
            }
        }
    }
}
