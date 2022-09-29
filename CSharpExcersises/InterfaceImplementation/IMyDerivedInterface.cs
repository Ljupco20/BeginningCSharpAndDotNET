using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceImplementation
{
    internal interface IMyDerivedInterface : IMyBaseInterface
    {
        new void DoSomething();
    }
}
