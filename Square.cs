using System;

namespace BaiTapIColorable
{
    public class Square : Rectangle
    {
        public Square(){}
        public Square(double side) : base(side, side){}
        public Square(double side, String color, bool filled) : base(side, side, color, filled){}
        public double GetSide()
        {
            return GetWidth();
        }
        public void SetSide(double side)
        {
            SetWidth(side);
            SetHeight(side);
        }
        public override void SetWidth(double width)
        {
            SetSide(width);
        }
        public override void SetHeight(double height)
        {
            SetSide(height);
        }
        public override String ToString()
        {
            return "A Square with side = " + GetSide()+ ", which is a subclass of "+ base.ToString();
        }
        
    }
}