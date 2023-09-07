using System;
namespace Swaps
{
    class NumberManipulator
    {
        public void Swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] arrgs)
        {
            NumberManipulator n = new NumberManipulator();
            int a;
            int b;
            Console.Write("Enter the number :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number :");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Befor swap, value of a : {0}", a);
            Console.WriteLine("Befor swap, value of b : {0}", b);
            n.Swap(ref a,ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
            Console.ReadLine();
        }
    }
}