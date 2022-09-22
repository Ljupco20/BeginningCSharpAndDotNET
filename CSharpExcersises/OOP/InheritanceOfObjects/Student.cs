using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOfObjects
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {

        }

        public void Studying()
        {
            Console.WriteLine("I am studying");
        }
    }
}
