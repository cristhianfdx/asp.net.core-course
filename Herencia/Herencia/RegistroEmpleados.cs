using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class RegistroEmpleados : Empleado
    {
        private int numRegistro;
        public int numReg
        {
            get { return numRegistro; }
            set { numRegistro = value; }
        }
    }
}
