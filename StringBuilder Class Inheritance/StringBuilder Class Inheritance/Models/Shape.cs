﻿namespace StringBuilder_Class_Inheritance.Models
{
    public class Shape
    {
        public string Color;
        public double Area;

        public Shape(string color)
        {
            Color = color;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Color: {Color}, Area: {Area}");
        }
    }
}
