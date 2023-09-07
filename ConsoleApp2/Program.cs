using System;
namespace circle_area
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the R:");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area is " + c_area(r));
            Console.ReadLine();
        }
        static double c_area(double r)
        {
            double radius = r;
            double pi = Math.PI;
            double area = pi * (radius * radius);
            return area;
        }
    }
}

