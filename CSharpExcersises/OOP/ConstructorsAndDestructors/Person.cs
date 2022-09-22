using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndDestructors
{
    internal class Person
    {
        private string Name;
        public Person(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        ~Person()
        {
            Name = String.Empty;
        }
    }
}
