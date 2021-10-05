using System;
using System.Collections.Generic;
using System.Text;

namespace Yashrajsinh_Jadeja_8740678
{
    public class Rectangle
    {
        //2 members Lenght,Width
        private int length, width;

        //Default Constructor to set Value 1
        public Rectangle()  {
            length = 1;
            width = 1;
        }

        //Parameterised Constructor 
        public Rectangle(int length, int width) {
            this.length = length;
            this.width = width;
        }
        //Getter for Length
        public int GetLength() {
            return length;
        }
        //Setter for length
        public int SetLength(int Length) {
            length = Length;
            return length;
        }
        //Getter for Width
        public int GetWidth() {
            return width;
        }
        //Setter fot Width
        public int SetWidth(int Width) {
            width = Width;
            return width;
        }
        //For Perimeter
        public int GetPerimeter() {
            return 2*(width + length);
        }
        //For Area
        public int GetArea() {
            return (width * length);
        }

    }
}
