using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Table
    {
        protected int height;
        public int Height 
        {

            get { return height; }
            set { height = value; } 
        }
        protected int width;
        public int Width 
        { get { return width; } 
          set { width = value; } 
        }

        public int SurfaceArea;

        public Table(int newHeight, int newWidth)
        {
            this.height = newHeight;
            this.width = newWidth;
        }

        public void ShowData()
        {
            SurfaceArea = Height * Width;
            Console.WriteLine($" The height of the board is" +
            $" {Height}cm, the width is {Width}cm and the Surface area is {SurfaceArea}cm2");
        }
    }
}
