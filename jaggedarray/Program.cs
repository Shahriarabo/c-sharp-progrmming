using System;
namespace Array
{
    class Myclass
    {
        static void Main(string[] args)
        {
            int[][] a = new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 }, new int[] { 4, 4 }, new int[] { 5, 5 } };
            int i, j;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("a[{0}][{1}] = {2}", i, j, a[i][j]);

                }
            }
            Console.ReadKey();
        }
    }
}