using Eps.DaseDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eps.Interfaz
{
    public partial class PacienteRead : Form
    {
        PacienteDao paciente = new PacienteDao();
        public PacienteRead()
        {
            InitializeComponent();
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            VisibleM(true);
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {
            mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
        
            if (Validaciones.ValidarVacio(txtCedP))
            {
                int CedulaP = Convert.ToInt32(txtCedP.Text);

                int regP = paciente.EliminarPaciente(CedulaP);
                if (regP == 1)
                {
                    MessageBox.Show("El Paciente fue Eliminado Exitosamente");
                    VisibleM(false);
                    mostrar();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Paciente");
                }

            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        public void mostrar()
        {
            DataSet dataSetP = new DataSet();
            dataSetP = paciente.MostrarPaciente();
            dgvPacientes.DataSource = dataSetP.Tables["MostrarP"];
        }

        public void VisibleM(Boolean ver)
        {
            txtCedP.Visible = ver;
            lvlcedula.Visible = ver;
            btnEliminar.Visible = ver;
        }
    }
}
