using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidad;
using capaNegocio;

namespace capaPresentacion
{
    public partial class FormEstudiante : Form
    {
        NegEstudiante estudianteNeg = new NegEstudiante();
        EntEstudiante estudianteEnt = new EntEstudiante();

        public FormEstudiante()
        {
            InitializeComponent();
            txtId.Hide();
            //cBoxCarrera.Items.Add("Seleccione Carrera");
        }

        private void FormEstudiante_Load(object sender, EventArgs e)
        {    
            mostrarEstudiantes();
            cargarComboBox();
        }

        void cargarComboBox()
        {
            cBoxCarrera.Items.AddRange(estudianteNeg.getCarreras());            
        }

        void mostrarEstudiantes()
        {
            DataTable tabla = estudianteNeg.getEstudiante();
            dGviewEstudiantes.DataSource=tabla;
        }      

        private void btnInsert_Click(object sender, EventArgs e)
        {
            estudianteNeg.createEstudiante(txtCodigo.Text);
            mostrarEstudiantes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            estudianteNeg.deleteEstudiante(txtCodigo.Text);
            mostrarEstudiantes();
        }

        public ArrayList obtenerDatos()
        {
            var datos = new ArrayList();

            datos.Add(txtCodigo.Text);
            datos.Add(txtNombre.Text);
            datos.Add(datePicker.Text);

            if (rBMasculino.Checked)
            {
                datos.Add("M");
            }else if (rBFemenino.Checked)
            {
                datos.Add("F");
            }



            return datos;
        }

        
    }
}
