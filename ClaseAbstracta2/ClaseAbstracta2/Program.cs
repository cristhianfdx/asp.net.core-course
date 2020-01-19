using System;

namespace ClaseAbstracta2
{
    class Program
    {
        static void Main(string[] args)
        {
            Planta p = new Planta();
            p.alimentarse();

            Carnivoro c = new Carnivoro();
            c.alimentarse();

        }
    }
}
