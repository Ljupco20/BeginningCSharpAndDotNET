using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    internal class MyClass : IMyInterface
    {
        public int MyProperty { get ; set ; }

        public void DoSomething() {
            Console.WriteLine("Doing something");
        }
        public void DoSomethingElse() { }
    }
}
