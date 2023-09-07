using System;
namespace Sample
{
    class Test
    {
        public static void Main(string[] args)
        { 
            int a, b, c, d, e, f, g;
            Console.Write("Enter the number :- ");
            a =Convert.ToInt32( Console.ReadLine());
            Console.Write("Enter the number :- ");
            b = Convert.ToInt32( Console.ReadLine());
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            g = a % b;
            c = a++;
            c = a--;
            Console.WriteLine("Sun is :" + c);
            Console.WriteLine("Sun is :" + d);
            Console.WriteLine("Sun is :" + e);
            Console.WriteLine("Sun is :" + f);
            Console.WriteLine("Sun is :0" + g);
            Console.WriteLine("Sun is :" + c);
            Console.WriteLine("Sun is :" + c);
            Console.ReadLine();
        }
    }
}


  





