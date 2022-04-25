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
    public partial class CitasPaciente : Form
    {
        CitaDao citaDao = new CitaDao();
        MultaDao multaDao = new MultaDao();
        PacienteDao pacienteDao = new PacienteDao();

        public CitasPaciente()
        {
            InitializeComponent();
        }

        private void BuscarC_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtCedP))
            {
                int CedulaP = Convert.ToInt32(txtCedP.Text);
                String EstadoC = "Por Asistir";
                DataSet dataSetM = new DataSet();
                dataSetM = citaDao.MostrarCitaP(CedulaP, EstadoC);
                dgvMostarP.DataSource = dataSetM.Tables["CitaPaciente"];
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostarB(true);
        }

        private void btnAsisitio_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtIdC))
            {
                int id = Convert.ToInt32(txtIdC.Text);
                String Estado = "Asistio";

                int reg = citaDao.ActualizarEstadoCita(id, Estado);
                if (reg == 1)
                {
                    MessageBox.Show("Se Actualizo correctamente el Estado de la Cita");
                    LimpiarCampos();
                    MostarB(false);
                }
                else
                {
                    MessageBox.Show("No se logro Actualizar el Estado de la Cita");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void btnNoAsistio_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtIdC) && Validaciones.ValidarVacio(txtCedP))
            {
                int id = Convert.ToInt32(txtIdC.Text);
                int Cedula = Convert.ToInt32(txtCedP.Text);
                String Estado = "No Asistio";
                String PazySalvo = "false";

                int regP = pacienteDao.actualizarPazySalvo(Cedula, PazySalvo);
                int regC = citaDao.ActualizarEstadoCita(id, Estado);
                if (regC == 1)
                {
                    Multa multa = new Multa(Cedula, 4000);
                    int regM = multaDao.RegistrarMulta(multa);
                    if (regM == 1)
                    {
                        MessageBox.Show("Se a Generado Una Multa al Paciente");
                        MostarB(false);
                    }
                    else
                    {
                        MessageBox.Show("No se logro Generar multa al Paciente");
                    }
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se logro Actualizar el Estado de la Cita");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }
        public void LimpiarCampos()
        {
            txtIdC.Text = "";
            txtCedP.Text = "";
        }

        private void txtCedP_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        public void MostarB(Boolean ver)
        {
            lbId.Visible = ver;
            txtIdC.Visible = ver;
            btnAsisitio.Visible = ver;
            btnNoAsistio.Visible = ver;
            cancelar.Visible = ver;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarVacio(txtIdC))
            {
                int id = Convert.ToInt32(txtIdC.Text);

                int reg = citaDao.EliminarCita(id);
                if (reg == 1)
                {
                    MessageBox.Show("La cita fue cancelada Exitosamente");
                    LimpiarCampos();
                    MostarB(false);
                }
                else
                {
                    MessageBox.Show("No se logro cancelar la Cita");
                }
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }
    }
}
