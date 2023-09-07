using System;
namespace Apps
{
    class tecst
    {
        static void Main(string[] args)
        {
            int a ,b, c;
            Console.Write("Enter the frist number A :- ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number B :-" );
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;

            Console.WriteLine("Your Result is A :-" + a );
            Console.WriteLine("Your Result is B :-" + b);
        }
    }
}