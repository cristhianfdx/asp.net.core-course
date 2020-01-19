using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar un array
            int[] a1;
            a1 = new int[5];
            //---------------------
            int [] a2 = new int[5];
            //---------------------
            string [] a3 = {"Cristhian", "Maria", "Paola" };
            //--Forma lenta---------------
            int[] a4 = new int[5] { 1, 2, 3, 4, 5 };

            //Clase Array

            int[] a5 = new int[5] { 5, 3, 4, 1, 2 };

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine(a5[i]);
            }

            Array.Sort(a5);//Ordena el array
            Console.WriteLine("----------------------");

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine(a5[i]);
            }

            Array.Reverse(a5);
            Console.WriteLine("------------------------");

            for (int i = 0; i < a5.Length; i++)
            {
                Console.WriteLine(a5[i]);
            }

            Array arr = Array.CreateInstance(typeof(int), new int[1] { 5 }, new int[1] { 1 });
            
        }
    }
}
