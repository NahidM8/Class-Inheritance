namespace StringBuilder_Class_Inheritance.Models
{
    public class Circle:Shape
    {
        public int Radius;

        public Circle(string color,int radius):base(color)
        {
            Radius = radius;
            Area = (int)(Math.PI * radius * radius);
        }
    }
}
