using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App2.Models
{
    public class Evaluación
    {
        public Alumno Alumno { get; set; }
        public Asignatura Asignatura { get; set; }

        public float Nota { get; set; }

        public override string ToString()
        {
            return $"{Nota}, {Alumno.Nombre}, {Asignatura.Nombre}";
        }
    }
}
