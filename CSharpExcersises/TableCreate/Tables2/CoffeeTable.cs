using Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables2
{
    public class CoffeeTable : Table
    {
        protected int height;
        public int Height
        {

            get { return height; }
            set { height = value; }
        }
        protected int width;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Surface
        {
            get { return height * width; }
        }
        public CoffeeTable(int newHeight, int newWidth) : base(newHeight, newWidth)
        {
            this.height = newHeight;
            this.width = newWidth;
        }
        public void ShowData()
        {
           
            Console.WriteLine($" The height of the table is" +
            $" {Height}cm, the width is {Width}cm and the Surface of the table is {Surface}cm2");
        }
    }
}
    

