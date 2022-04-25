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
    public partial class CitasCreate : Form
    {
        CitaDao citaDao = new CitaDao();
        MultaDao multaDao = new MultaDao();
        PacienteDao pacienteDao = new PacienteDao();
        MedicoDao medicoDao = new MedicoDao();
        DataSet dataSetM = new DataSet();

        public CitasCreate()
        {
            InitializeComponent();
        }

        private void btnRCita_Click(object sender, EventArgs e)
        {

            if (Validaciones.ValidarVacio(txtIdPc) && Validaciones.ValidarVacio(txtIdMc) && (cbCita.Text != ""))
            {
                int CedulaP = Convert.ToInt32(txtIdPc.Text);
                int CedulaM = Convert.ToInt32(txtIdMc.Text);
                String FechaCita = cFechaCita.Text;
                String TipoCIta = cbCita.Text;
                String EstadoCita = "Por Asistir";


                dataSetM = pacienteDao.BuscarPaciente(CedulaP);
                int ValidarRP = dataSetM.Tables["BuscarP"].Rows.Count;

                if (ValidarRP == 1)
                {
                    dataSetM = medicoDao.BuscarMedico(CedulaM);
                    int ValidarRM = dataSetM.Tables["BuscarM"].Rows.Count;

                    if(ValidarRM == 1)
                    {
                        dataSetM = multaDao.MostrarMulta(CedulaP);
                        int ValidarPazySalvo = dataSetM.Tables["Multa"].Rows.Count;

                        if (ValidarPazySalvo == 0)
                        {
                            dataSetM = citaDao.MostarTipoCita(CedulaP, TipoCIta, EstadoCita);
                            int ValidarCantidaTipoCita = dataSetM.Tables["TipoCita"].Rows.Count;
                            if (ValidarCantidaTipoCita != 1)
                            {
                                dataSetM = citaDao.MostrarCitaP(CedulaP, EstadoCita);
                                int ValidarCantidaAsistir = dataSetM.Tables["CitaPaciente"].Rows.Count;
                                if (ValidarCantidaAsistir != 2)
                                {
                                    Cita cita = new Cita(TipoCIta, CedulaP, CedulaM, FechaCita, EstadoCita);
                                    int regC = citaDao.RegistrarCita(cita);
                                    if (regC == 1)
                                    {
                                        MessageBox.Show("Se ingresaron correctamente la información de la Cita");
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se logro ingresar la información de la Cita");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("El Paciente ya tiene 2 citas Registradas");
                                }
                            }
                            else
                            {
                                MessageBox.Show("El Paciente ya Tiene una Cita de este Tipo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El Paciente no se Encuentra Paz y Salvo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Medico no se Encuentra Registrado");
                    }
                }
                else
                {
                    MessageBox.Show("El Paciente no se Encuentra Registrado");
                }








                
            }
            else
            {
                MessageBox.Show("Se Encuentran Campos Vacios");
            }
        }

        private void txtIdPc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }

        private void txtIdMc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloInt(e);
        }
    }
}
