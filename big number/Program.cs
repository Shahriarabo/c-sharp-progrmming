using System;
namespace Apps
{
    class Taset
    {
        static void Main(string[] args)
        {
            //int a, b, c;
            //Console.Write("Enter the number :- ");
            //a = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter the number :- ");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the number :- ");
            //c = Convert.ToInt32(Console.ReadLine());


            // if (a > b && a > c)
            //{
            //   Console.WriteLine("A is big");
            //}
            //else if( b > a && b > c)
            // {
            //   Console.WriteLine("B is big");
            //}
            /// else
            //  {
            ///   Console.WriteLine("C is big");
            /// }


            int a,b, c;
            Console.Write("Enter the number :- ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number :- ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number :- ");
            c = Convert.ToInt32(Console.ReadLine());


            if (a > b) 
            {
                if (a > c)
                {
                    Console.WriteLine("A is big");
                }
                else
                {
                    Console.WriteLine("C is big");
                }
            }
            else
            {
                if ( b> c)
                {
                    Console.WriteLine("B is big");
                }
            }






        }
    }
}