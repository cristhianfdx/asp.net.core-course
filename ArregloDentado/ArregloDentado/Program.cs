using System;

namespace ArregloDentado
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[3] { 1, 2, 3 };

            arr[1] = new int[2] { 4, 5 };

            Console.WriteLine(arr[0][0]);

            Console.WriteLine(arr[0][1]);

            Console.WriteLine(arr[0][2]);

            Console.WriteLine(arr[1][0]);

            Console.WriteLine(arr[1][1]);

        }
    }
}
