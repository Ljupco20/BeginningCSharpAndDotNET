using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBookClass
{
    internal class PhotoBook
    {
        private int numPages { get; set; }
        public int GetNumberPages()
        {
            return numPages;
        }

        public PhotoBook()
        {
            numPages = 16;
        }
        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }
    }
}
