using System;

namespace ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion
            int[,] matriz = new int[3, 2];
            //----------------------------
            int[,] mat2 = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 0 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(mat2[i,j]);
                }
            }
        }
    }
}
