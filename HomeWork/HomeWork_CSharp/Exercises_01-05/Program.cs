using System;

namespace Exercises_01_05
{
    internal class Program
    {
        static void Main(string[] args)

        {
            double number;
            double product = 1;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Please enter a number");
                number = Convert.ToDouble(Console.ReadLine());
                product *= number;
                
            }

            Console.WriteLine($"The product of the 4 numbers you've entered is {product}");
            Console.ReadKey();


        }

        /*
        Exercise 01 - In the following code, how would you refer to the name great from code in the namespace fabulous?

        namespace fabulous
        {
        super.smashing.great
        }
        namespace super
        {
        namespace smashing
        {
        // great name defined
        }
        } 
        Exercise 02 - Which of the following is not a legal variable name?
        ➤➤ myVariableIsGood
        ➤➤ 99Flake ---------- you cant star with numbest
        ➤➤ _floor
        ➤➤ time2GetJiggyWidIt
        ➤➤ wrox.com  ---------- you cant have dot

        Exercise 03 - Is the string "supercalifragilisticexpialidocious" too big to fit in a string variable? If so, why?
        No it's not.

        Exercise 04 - By considering operator precedence, list the steps involved in the computation of the following expression:
        var1 * var2
        var3 % var4 
        (var3 % var4) / var5
        (var1 * var2) + (var3 % var4 / var5)
         */


    }
}
