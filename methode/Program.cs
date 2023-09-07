using System;
namespace Calculation
{
    class NumberManipulator
    {
        public int Findmax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else result = num2;
            return result;
        }
        static void Main(string[] args)
        {
            int a = 900;
            int b = 200;
            int ret;
            NumberManipulator n = new NumberManipulator();
            ret = n.Findmax(a, b);
            Console.WriteLine("Max value is : {0}", ret);
            Console.ReadLine();
            
        }
    }
}