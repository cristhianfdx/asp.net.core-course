using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace capaDatos
{
    class ConexionBD
    {
        SqlConnection conex = null;
        public SqlConnection getConexion()
        {
            try
            {
                conex = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlConex"].ConnectionString);
            }
            catch (SqlException err)
            {
                Console.WriteLine("Error en la conexón:"+ err);
            }
            
            return conex;
        }
    }
}
