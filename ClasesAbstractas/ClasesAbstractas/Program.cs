using System;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejecutar op = new Ejecutar(1,2);
            int suma= op.suma();
            int resta = op.resta();
            int mult = op.multiplicacion();
            double div = op.division();

            Console.WriteLine("La suma es : {0}",suma);
            Console.WriteLine("La resta es : {0}", resta);
            Console.WriteLine("La multiplicación es : {0}", mult);
            Console.WriteLine("La división es : {0}", div);

        }
    }
}
