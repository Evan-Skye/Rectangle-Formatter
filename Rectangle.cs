using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleFormatter
{
    class Rectangle
    {
        private static int NUMBER_OF_SIDES = 2;
        private int width;
        private int length;
        public Rectangle()
        {
            width = 1;
            length = 1;
        }

        public Rectangle(int width, int length)
        {
            this.width = width;
            this.length = length;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            int perimeter = (width * NUMBER_OF_SIDES) + (length * NUMBER_OF_SIDES);
            return perimeter;
        }

        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
