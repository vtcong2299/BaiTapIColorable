using System;
using System.Security.Authentication;

namespace BaiTapIColorable
{
    class Program
    {
        static void Main(string[]args)
        {
            Shape[] shapes = new Shape[4];
            shapes[0] = new Circle(3.5);
            shapes[1] = new Rectangle(2.4,5);
            shapes[2] = new Circle(2.3);
            shapes[3] = new Square(5);

            foreach (Shape shape in shapes)
            {
                if (shape is IColorable)
                {
                    ((IColorable)shape).HowToColor();
                }
                Console.WriteLine("Dien tich: "+ shape.GetArea());
            }
        }
    }
}