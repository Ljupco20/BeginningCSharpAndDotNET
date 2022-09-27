using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Homework
{
    internal class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";
        public HouseCat(string name, double weight) : base(weight)  
        {
            Name = name;
        }
        public HouseCat(string name)
        {
            Name = name;
        }
        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }
        public override string Noise()
        {
            if (IsSatisfied())
            {
                return $"Hello, my name is {Name}!";
            }
            else
            {
                return base.Noise();// prints "Meow!"
            }
           
        }
        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
