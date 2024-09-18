using System;

namespace BaiTapIColorable
{
    public class Circle:Shape, IColorable
    {        
        public double radius = 1.0;
        public double GetRadius()
        { 
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius=radius;
        }
        public Circle(){}
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled) : base(color,filled)
        {
            this.radius = radius;
        }
        public override double GetArea ()
        {
            return radius*radius*3.14;
        }
        public double GetPerimeter ()
        {
            return 2*radius*3.14;
        }
        public override string ToString()
        {
            return "A Circle with radius "+ GetRadius()+ " which is a subclass of " + base.ToString();
        }
        public void HowToColor()
        {
            Console.WriteLine("Mau do");
        }
    }
}