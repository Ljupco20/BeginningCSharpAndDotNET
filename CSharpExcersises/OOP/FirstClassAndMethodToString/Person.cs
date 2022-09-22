using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstClassAndMethodToString
{
    internal class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    
}
