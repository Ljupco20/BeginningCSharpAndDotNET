using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10._1Exercises
{
    internal class MyDerivedClass : MyClass
    {
        public override string GetString()
        {
            return MyString + "(output from derived class)";
        }
    }
}
