using System;
using System.Collections;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            //Agregar elementos

            arrList.Add(1);
            arrList.Add("Hola");

            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }

            foreach (var val in arrList)
            {
                Console.WriteLine(val);
            }

            //Remover elementos
            arrList.Remove("Hola");

            foreach (var val in arrList)
            {
                Console.WriteLine(val);
            }

        }
    }
}
