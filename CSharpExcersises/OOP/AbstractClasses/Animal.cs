using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class Animal
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }
        public bool SetName(string name)
        {
            _name =name;
            return true;
        }
        public abstract void Eat();
    }
}
