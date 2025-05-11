namespace StringBuilder_Class_Inheritance.Models
{
    public class Rectangle:Shape
    {
        public int Length;
        public int Width;
        public Rectangle(string color, int length, int width) : base(color)
        {
            Length = length;
            Width = width;
            Area = length * width;
        }
    }
}
