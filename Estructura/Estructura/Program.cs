using System;

namespace Estructura
{
    class Program
    {
        static void Main(string[] args)
        {
            Prueba p = new Prueba();

            p.color = "rojo";

            Console.WriteLine(p.color);

            
        }

        public struct Prueba
        {
            public string color { get; set; }
        }
    }
}
