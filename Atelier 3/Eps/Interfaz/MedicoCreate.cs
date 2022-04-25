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
    public partial class MedicoCreate : Form
    {
        public MedicoCreate()
        {
            InitializeComponent();
        }

        private void btnRegistrarM_Click(object sender, EventArgs e)
        {
            MedicoDao medicoDao = new MedicoDao();
            DataSet dataSetM = new DataSet();

            if (Validaciones.ValidarVacio(txtCedM) && Validaciones.ValidarVacio(txtCedM) && Validaciones.ValidarVacio(txtCedM) && Validaciones.ValidarVacio(txtCedM) && Validaciones.ValidarVacio(txtCedM) && (cbEzpM.Text != ""))
            {
                int Cedula = Convert.ToInt32(txtCedM.Text);

                dataSetM = medicoDao.BuscarMedico(Cedula);
                int ValidarRM = dataSetM.Tables["BuscarM"].Rows.Count;

                if(ValidarRM == 0)
                {
                    String Nombre = txtNomM.Text;
                    String Apellido = txtApeM.Text;
                    String Expecialidad = cbEzpM.Text;
                    String Saldo = txtSalM.Text;
                    String AñosXP = txtAxpM.Text;

                    Medico med = new Medico(Cedula, Nombre, Apellido, Expecialidad, Saldo, AñosXP);
                    int reg = medicoDao.RegistrarMedico(med);

                    if (reg == 1)
                    {
                        MessageBox.Show("Se ingresaron correctamente la información del Medico");
                    }
                    else
                    {
                        MessageBox.Show("No se logro ingresar la información del Medico");
                    }
                }
                else
                {
                    MessageBox.Show("El Medico ya se Encuentra Registrado");
                }              
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void txtCedM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtNomM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void txtApeM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void txtSalM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtAxpM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }
    }
}
