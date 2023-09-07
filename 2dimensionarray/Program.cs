using System;
namespace Array
{
    class Demo
    {
        static void Main()
        {
            int t, i;
            int[,] table = new int[3, 4];
            for (t = 0; t < 3; t++) {
                Console.Write("t\ 4] +" );
                for (i = 0; i < 4; ++i)
                table[t, i] = (t * 4) + i + 1;
                
            }
             Console.WriteLine();
        }
    }
}