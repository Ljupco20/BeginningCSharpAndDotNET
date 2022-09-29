using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    internal class MyBaseClass : IMyBaseInterface
    {
        public int MyInt { get; set; }
        public virtual void DoSomething() { }
        public virtual void DoSomethingElse() { }
    }
}
