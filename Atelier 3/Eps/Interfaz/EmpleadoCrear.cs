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
    public partial class EmpleadoCrear : Form
    {
        public EmpleadoCrear()
        {
            InitializeComponent();
        }

        private void btnRegE_Click(object sender, EventArgs e)
        {
            EmpleadoDao empleadoDao = new EmpleadoDao();
            DataSet dataSetM = new DataSet();

            if (Validaciones.ValidarVacio(txtCedE) && Validaciones.ValidarVacio(txtNomE) && Validaciones.ValidarVacio(txtApeE) && Validaciones.ValidarVacio(txtConE) && Validaciones.ValidarVacio(txtConRE))
            {
                int Cedula = Convert.ToInt32(txtCedE.Text);

                dataSetM = empleadoDao.BuscarEmpleado(Cedula);
                int ValidarRE = dataSetM.Tables["BuscarE"].Rows.Count;

                if (ValidarRE == 0)
                {
                    String Nombre = txtNomE.Text;
                    String Apellido = txtApeE.Text;
                    String Contraseña = txtConE.Text;
                    String RContraseña = txtConRE.Text;

                    if (Validaciones.ValidarContraseñas(Contraseña, RContraseña))
                    {
                        Empleado emp = new Empleado(Cedula, Nombre, Apellido, Contraseña);
                        int reg = empleadoDao.RegistrarEmpleado(emp);

                        if (reg == 1)
                        {
                            MessageBox.Show("Se ingresaron correctamente la información del Empleado");
                        }
                        else
                        {
                            MessageBox.Show("No se logro ingresar la información del Empleado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("la Contraseña no Coinciden");
                    }
                }
                else
                {
                    MessageBox.Show("El Empleado ya se Encuentra Registrado");
                }  
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }       
        }

        private void txtCedE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtNomE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }
    
        private void txtApeE_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloString(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciar = new IniciarSesion();
            this.Hide();
            iniciar.Show();
        }
    }
}
