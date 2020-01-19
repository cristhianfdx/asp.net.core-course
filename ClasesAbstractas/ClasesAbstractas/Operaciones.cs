using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    public abstract class Operaciones
    {
        public abstract int num1 { get; set; }
        public abstract int num2 { get; set; }
        public abstract int suma();
        public abstract int resta();
        public abstract int multiplicacion();
        public abstract double division();

    }
}
