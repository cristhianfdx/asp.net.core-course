using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using capaEntidad;
using System.Collections;

namespace capaDatos
{
    public class DatEstudiante
    {        
        ConexionBD conex;
        
        public DatEstudiante()
        {
            conex = new ConexionBD();
        }

        public string mensaje { get; set;}

        public DataTable listarEstudiantes()
        {
            var tablaEstudiantes = new DataTable();
            SqlConnection conectar = conex.getConexion();

            try
            {
                string consulta = "SELECT * FROM estudiante";
                
                using (var adaptador = new SqlDataAdapter(consulta, conectar))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;                    
                    adaptador.Fill(tablaEstudiantes);
                }
                                
                conectar.Close();

            }
            catch(SqlException err)
            {
                mensaje = "Error al Listar estudiantes:" + err.Message;
                generarMensaje();
                return tablaEstudiantes;
            }
            return tablaEstudiantes;
        }

        public void procesarEstudiante(string peticion, string codigo)
        {
            SqlConnection conectar = conex.getConexion();

            try
            {
                string consulta = "";                

                switch (peticion)
                {
                    case "INSERTAR":
                        consulta = "INSERT INTO estudiante (codigo, nombre, fecha, genero, carrera, intereses) VALUES(@cod, @nom, @fecha, @genero, @intereses)";
                    break;

                    case "ACTUALIZAR":
                        consulta = "";
                    break;

                    case "BORRAR":
                        consulta = "DELETE FROM estudiante where codigo="+codigo;
                        mensaje = "Estudiante eliminado";
                    break;
                }

                conectar.Open();

                using (var sentencia = new SqlCommand(consulta, conectar))
                {
                    if (peticion.Equals("BORRAR"))
                    {
                        sentencia.ExecuteNonQuery();
                    }
                    else
                    {
                        sentencia.Parameters.AddWithValue("","");
                    }
                    
                    generarMensaje();
                }

                conectar.Close();

            }
            catch(Exception err)
            {
                mensaje = "Error al Procesar estudiantes:" + err.Message;
                generarMensaje();
            }
        }

        public Object [] listarCarreras()
        {
            SqlConnection conectar = conex.getConexion();
            var carreras = new Object [6];
            DataSet datos = new DataSet();

            try
            {
                conectar.Open();

                using(var adaptador = new SqlDataAdapter("SELECT * FROM carreras",conectar))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(datos, "carreras");

                    for (int i = 0; i < carreras.Length; i++)
                    {
                        carreras[i] = datos.Tables[0].DefaultView;
                    }
                }

                conectar.Close();

            }
            catch (Exception err)
            {
                mensaje = "Error al Listar estudiantes:" + err.Message;
                generarMensaje();
            }

            return carreras;
        }

        public void generarMensaje()
        {
            System.Windows.Forms.MessageBox.Show(mensaje);
        }
    }
}
