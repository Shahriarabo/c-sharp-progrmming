using System;
namespace Oparetion
{
    class Program
    {
        private static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.Write("Enter the Number : ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Number : ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Number : ");
            number3 = Convert.ToInt32(Console.ReadLine());


            if (number1 > number2) 
            {
                Console.WriteLine("This is the big number1");
            }
            else if(number2 > number3)
            {
                Console.WriteLine("This is the big number2");
            }
            else
            {
                Console.WriteLine("This is the big number3");
            }
            
        }
    }
}

