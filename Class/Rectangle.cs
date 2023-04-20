using System;

namespace RectangleProgram
{
    class Rectangle
    {
        private int _length;
        private int _width;

        public Rectangle()
        {
            _length = 0;
            _width = 0;
        }

        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public int Area()
        {
            return _length * _width;
        }

        public void Display()
        {
            Console.WriteLine("Rectangle Dimension");
            Console.WriteLine("Length:" + _length);
            Console.WriteLine("Width:" + _width);
            Console.WriteLine("Area of the Rectangle:" + Area());
        }

        public Rectangle DimensionChange(int d)
        {
            return new Rectangle(_length * d, _width * d);
        }
    }
}
