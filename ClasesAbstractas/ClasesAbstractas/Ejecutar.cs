using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesAbstractas
{
    public class Ejecutar : Operaciones
    {
        public override int num1 { get; set; }
        public override int num2 { get; set; }
        public Ejecutar(int n1, int n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }

        

        public override int suma()
        {
            return num1 + num2;
        }
        public override int resta()
        {
            return num1 - num2;
        }
        public override int multiplicacion()
        {
            return num1 * num2;
        }
        public override double division()
        {
            return num1 / num2;
        }

    }
}
