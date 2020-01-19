using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaDatos;
using capaEntidad;
using System.Collections;

namespace capaNegocio
{
    public class NegEstudiante
    {
        DatEstudiante estudianteDatos = new DatEstudiante();

        public DataTable getEstudiante()
        {
            return estudianteDatos.listarEstudiantes();
        }

        public void createEstudiante(string id)
        {
            estudianteDatos.procesarEstudiante("INSERTAR", id);
        }

        public void deleteEstudiante(string codigo)
        {
            estudianteDatos.procesarEstudiante("BORRAR", codigo);
        }

        public Object [] getCarreras()
        {
            return estudianteDatos.listarCarreras();
        }

        
    }
}
