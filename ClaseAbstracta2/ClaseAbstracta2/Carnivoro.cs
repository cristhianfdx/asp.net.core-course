using System;
using System.Collections.Generic;
using System.Text;

namespace ClaseAbstracta2
{
    public class Carnivoro : Animal
    {
        public override void alimentarse()
        {
            Console.WriteLine("El animal carnivoro se alimenta de carne");
        }
    }
}
