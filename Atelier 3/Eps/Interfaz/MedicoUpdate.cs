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
    public partial class UpdateMedico : Form
    {
        public UpdateMedico()
        {
            InitializeComponent();
        }

        private void ActualizarM_Click(object sender, EventArgs e)
        {
            MedicoDao medicoDao = new MedicoDao();          
            if(Validaciones.ValidarVacio(txtCedMA) && Validaciones.ValidarVacio(txtNomMA) && Validaciones.ValidarVacio(txtSalMA))
            {
                int Cedula = Convert.ToInt32(txtCedMA.Text);
                String Nombre = txtNomMA.Text;
                String Saldo = txtSalMA.Text;

                int reg = medicoDao.ActualizarMedico(Cedula, Nombre, Saldo);
                if (reg == 1)
                {
                    MessageBox.Show("Se Actualizo correctamente la información del Medico");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se logro Actualizar la información del Medico");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }


        public void LimpiarCampos()
        {
            txtCedMA.Text = "";
            txtNomMA.Text = "";
            txtSalMA.Text = "";
        }

        private void txtCedMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtNomMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void txtSalMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }
    }
}
