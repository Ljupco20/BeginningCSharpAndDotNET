using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
    }
}
