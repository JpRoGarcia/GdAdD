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
    public partial class MedicoRead : Form
    {
        MedicoDao medico = new MedicoDao();
        public MedicoRead()
        {
            InitializeComponent();
        }

        private void btnMostrarM_Click(object sender, EventArgs e)
        {
            mostrar();
        }
        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            VisibleM(true);
        }

        public void mostrar()
        {
            DataSet dataSetP = new DataSet();
            dataSetP = medico.MostrarMedico();
            dgvPacientes.DataSource = dataSetP.Tables["MostrarMed"];
        }

        public void VisibleM(Boolean ver)
        {
            txtCedM.Visible = ver;
            lvlcedulaM.Visible = ver;
            btnEliminar.Visible = ver;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtCedM))
            {
                int CedulaM = Convert.ToInt32(txtCedM.Text);

                int regP = medico.EliminarMedico(CedulaM);
                if (regP == 1)
                {
                    MessageBox.Show("El Medico fue Eliminado Exitosamente");
                    VisibleM(false);
                    mostrar();
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Medico");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }

        }
    }
}
