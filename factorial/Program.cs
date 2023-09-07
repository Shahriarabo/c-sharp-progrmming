using System;
namespace Apps
{
    class NumberManipul
    {
        public int factorial(int num)
        {
            int result;
            if (num ==1)
            {
                return 1;
            }
            else
            {
                result = factorial(num - 1)*num;
                return result;
            }
        }
        static void Main(string[] args)
        {
            NumberManipul n = new NumberManipul();
            Console.WriteLine("Factorial number of 6 is : {0}", n.factorial(6));
            Console.WriteLine("Factorial number of 7 is : {0}", n.factorial(7));
            Console.WriteLine("Factorial number of 8 is : {0}", n.factorial(8));
            Console.WriteLine("Factorial number of 9 is : {0}", n.factorial(9));
            Console.ReadLine();
        }
    }   
}