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
    public partial class MultaRead : Form
    {
        MultaDao multa = new MultaDao();
        PacienteDao paciente = new PacienteDao();

        public MultaRead()
        {
            InitializeComponent();
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtCedP))
            {
                int CedulaP = Convert.ToInt32(txtCedP.Text);
                DataSet dataSetM = new DataSet();
                dataSetM = multa.MostrarMulta(CedulaP);
                dgvMulta.DataSource = dataSetM.Tables["Multa"];
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void btnPagarM_Click(object sender, EventArgs e)
        {
            VisibleM(true);
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtIdMulta) && Validaciones.ValidarVacio(txtCedP))
            {
                int idMulta = Convert.ToInt32(txtIdMulta.Text);
                int Cedula = Convert.ToInt32(txtCedP.Text);
                String PazSalvo = "true";

                int regM = multa.EliminarMulta(idMulta);
                paciente.actualizarPazySalvo(Cedula, PazSalvo);
                if (regM == 1)
                {
                    MessageBox.Show("El Pago fue Exitoso y se Encuentra Paz y Salvo");
                    VisibleM(false);
                }
                else
                {
                    MessageBox.Show("No se logro Generar el pago");
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

        public void VisibleM(Boolean ver) 
        {
            lblIDM.Visible = ver;
            txtIdMulta.Visible = ver;
            btnPagar.Visible = ver;
        }
    }
}
