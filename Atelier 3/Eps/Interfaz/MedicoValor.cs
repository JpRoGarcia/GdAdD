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
    public partial class MedicoValor : Form
    {
        MedicoDao medicoDao = new MedicoDao();
        public MedicoValor()
        {
            InitializeComponent();
        }

        private void BuscarValor_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtCedM))
            {
                int Cedula = Convert.ToInt32(txtCedM.Text);
                DataSet dataSetM = new DataSet();
                dataSetM = medicoDao.MostrarValor(Cedula);
                dtvValorM.DataSource = dataSetM.Tables["Medico"];
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        public void LimpiarCampos()
        {
            txtCedM.Text = "";
        }

        private void txtCedM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }
    }
}
