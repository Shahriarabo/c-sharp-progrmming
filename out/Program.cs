using System;
namespace Swaps
{
    class NumberManipulator
    {
        public void Getvalues(out int x, out int y)
        {
            Console.Write("Enter the number :");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number :");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] arrgs)
        {
            NumberManipulator n = new NumberManipulator();
            int a ,b;
            n.Getvalues(out a, out b);
            Console.WriteLine(" value of a : {0}", a);
            Console.WriteLine(" value of b : {0}", b);
            Console.ReadLine();
        }
    }
}