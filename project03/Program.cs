
using System;
namespace oparetion
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;
            double r;
            Console.Write("Enter the Bahu Number :");
            r = Convert.ToDouble(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Area is : " + area);
        }
    }
}