using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch10._1Exercises
{
    internal class MyClass
    {
        protected string MyString;
        public virtual string GetString()
        {
            return MyString;
        }
        public string ContainedString
        {
            set
            {
                MyString = value;
            }
        }
    }
}
