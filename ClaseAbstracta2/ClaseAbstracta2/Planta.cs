using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta2
{
    public class Planta : SerVivo
    {
        public override void alimentarse()
        {
            Console.WriteLine("La planta se alimenta mediante la fotosintesís");
        }
    }
}
