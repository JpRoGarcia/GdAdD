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
    public partial class UpdatePaciente : Form
    {
        public UpdatePaciente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PacienteDao pacienteDao = new PacienteDao();

            if(Validaciones.ValidarVacio(txtCedP) && Validaciones.ValidarVacio(txtEmailP) && Validaciones.ValidarVacio(txtDirP) && Validaciones.ValidarVacio(txtTelP))
            {
                int Cedula = Convert.ToInt32(txtCedP.Text);
                String Email = txtEmailP.Text;
                String Direccion = txtDirP.Text;
                String Telefono = txtTelP.Text;
                if (Validaciones.VerificacionEMail(Email))
                {
                    int reg = pacienteDao.actualizarPaciente(Cedula, Email, Direccion, Telefono);
                    if (reg == 1)
                    {
                        MessageBox.Show("Se Actualizo correctamente la información del Paciente");
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se logro Actualizar la información del Paciente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        public void LimpiarCampos()
        {
            txtCedP.Text = "";
            txtEmailP.Text = "";
            txtDirP.Text = "";
            txtTelP.Text = "";
        }

        private void txtCedP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtTelP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        } 
    }
}
