using System;
namespace Apps
{
    class ArrayDemo
    {
        static void Main(string[] args)
        {
            /* int[] sample = new int[10];
             int a;
             Console.Write("Enter the number:");
             a = Convert.ToInt32(Console.ReadLine());
             for (i = 0; i <a; i++)
                 sample[a] = i;
             for (i = 0; i < a; a = i + 1)
                 Console.WriteLine("sample[" + a + "] : " + sample[i]);*/



            int t, i;
            int[,] table = new int[3, 4];
            for (t = 0; t < 3; t++)
            {
                for (i = 0; i < 4; ++i)
                    table[t, i] = (t * 4) + i + 1;
                Console.WriteLine(table[t, i] + " ");



            }
            Console.WriteLine();
        }
    }

}