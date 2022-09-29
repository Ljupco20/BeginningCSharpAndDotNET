using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class MyClass
    {
        #region Fields
        public int myInt;
        #endregion
        #region Constructor
        public MyClass() { myInt = 99; }
        #endregion
        #region Properties
        public int MyInt
        {
            get { return myInt; }
            set { myInt = value; }
        }
        #endregion
        #region Methods
        public void DoSomething()
        {
            // Do something..
        }
        #endregion
    }
    public partial class MyClass
    {
        #region Fields
        public int myInt2;
        #endregion
    }
}
