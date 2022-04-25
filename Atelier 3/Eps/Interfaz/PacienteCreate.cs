using Eps.DaseDatos;
using Eps.Usuario;
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
    public partial class PacienteCreate : Form
    {
        public PacienteCreate()
        {
            InitializeComponent();
        }

        private void btnRegistrarP_Click(object sender, EventArgs e)
        {
            PacienteDao pacienteDao = new PacienteDao();
            DataSet dataSetM = new DataSet();

            if (Validaciones.ValidarVacio(txtCedP) && Validaciones.ValidarVacio(txtNomP) && Validaciones.ValidarVacio(txtApeP) && Validaciones.ValidarVacio(txtEmailP) && Validaciones.ValidarVacio(txtDirP) && Validaciones.ValidarVacio(txtTelP))
            {
                int Cedula = Convert.ToInt32(txtCedP.Text);

                dataSetM = pacienteDao.BuscarPaciente(Cedula);
                int ValidarRP = dataSetM.Tables["BuscarP"].Rows.Count;

                if(ValidarRP == 0)
                {
                    String Nombre = txtNomP.Text;
                    String Apellido = txtApeP.Text;
                    String FechaN = dataFechaNacP.Text;
                    String Email = txtEmailP.Text;
                    String Direccion = txtDirP.Text;
                    String Telefono = txtTelP.Text;
                    String FechaR = dataFechaRP.Text;
                    String PazySalvo = "true";
                    if (Validaciones.VerificacionEMail(Email))
                    {
                        Paciente pac = new Paciente(Cedula, Nombre, Apellido, FechaN, Direccion, Email, Telefono, FechaR, PazySalvo);
                        int reg = pacienteDao.RegistrarPaciente(pac);

                        if (reg == 1)
                        {
                            MessageBox.Show("Se ingresaron correctamente la información del Paciente");
                        }
                        else
                        {
                            MessageBox.Show("No se logro ingresar la información del Paciente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email Incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("El Paciente ya se Encuentra Registrado");
                }           
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void txtCedP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtNomP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void txtApeP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void txtTelP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }
    }
}
