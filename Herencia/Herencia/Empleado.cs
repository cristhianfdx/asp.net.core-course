using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Empleado 
    {
        private int idEmpleado;
        private string nombres;
        private string apellidos;

        public int id_empleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public string nombres_empleado
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string apellidos_empleado
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

    }
}
