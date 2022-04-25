using Eps.DaseDatos;
using Eps.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eps
{
    public partial class IniciarSesion : Form
    {
        
        EmpleadoDao empleadoDao = new EmpleadoDao();
        DataSet dataSetM = new DataSet();

        public IniciarSesion()
        {
            InitializeComponent();
        }


        private void txtCedE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void btnRegitro_Click(object sender, EventArgs e)
        {
            EmpleadoCrear empleado = new EmpleadoCrear();
            empleado.Show();
            this.Hide();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(Validaciones.ValidarVacio(txtCedE) && Validaciones.ValidarVacio(txtConE))
            {
                int Cedula = Convert.ToInt32(txtCedE.Text);
                String Contraseña = txtConE.Text;

                dataSetM = empleadoDao.Autentificar(Cedula, Contraseña);
                int ValidarInicio = dataSetM.Tables["Iniciar"].Rows.Count;

                if (ValidarInicio == 1)
                {
                    MenuE menu = new MenuE();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("La Cedula y Contraseña no Coinciden");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }
    }
}
