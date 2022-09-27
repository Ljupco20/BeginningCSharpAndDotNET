using System;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.Intrinsics.X86;

namespace ExercisesCh09
{
    /*
     * 9.1 What is wrong with the following code?
     * 
    public sealed class MyClass
    {
        // Class members.
    }
    public class myDerivedClass : MyClass
    {
        // Class members.
    }
    */
    //Error CS0509  'myDerivedClass': cannot derive from sealed type 'MyClass'	

    //    9.2 How would you define a noncreatable class?
    //In summary, static classes can neither support instantiation nor inheritance.
    //This makes them ideal for use in utility classes that do not need further modifications.
    //On the other hand, if we need to add functionalities to our classes, non-static classes would be more ideal than their static counterparts.

    //9.3 Why are noncreatable classes still useful? How do you make use of their capabilities?

    //9.4 Write code in a class library project called Vehicles that implements the Vehicle family
    //of objects discussed earlier in this chapter.There are nine objects and two interfaces that
    //require implementation.

    //9.5 Create a console application project, Traffic, that references Vehicles.dll (created in
    //Exercise 9.4). Include a function called AddPassenger that accepts any object with the
    //IPassengerCarrier interface. To prove that the code works, call this function using
    //instances of each object that supports this interface, calling the ToString method
    //inherited from System.Object on each one and writing the result to the screen.
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
