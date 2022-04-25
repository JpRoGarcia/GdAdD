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
    public partial class MenuE : Form
    {
        IniciarSesion IniciarSesion = new IniciarSesion();

        PacienteCreate rpaciente = new PacienteCreate();
        PacienteRead pacienter = new PacienteRead();
        UpdatePaciente aPaciente = new UpdatePaciente();
        CitasPaciente citasP = new CitasPaciente();
        MultaRead multas = new MultaRead();

        MedicoCreate rmedico = new MedicoCreate();
        UpdateMedico aMedico = new UpdateMedico();
        MedicoValor valorMedico = new MedicoValor();
        MedicoRead medicor = new MedicoRead();

        CitasCreate rCitas = new CitasCreate();
        CitasIncumplidas incumplidas = new CitasIncumplidas();


        public MenuE()
        {
            InitializeComponent();
        }

        
        private void medicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rpaciente.MdiParent = this;
            rpaciente.Show();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aPaciente.MdiParent = this;
            aPaciente.Show();
            rpaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void multasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multas.MdiParent = this;
            multas.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void citasPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            citasP.MdiParent = this;
            citasP.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void registroMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rmedico.MdiParent = this;
            rmedico.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aMedico.MdiParent = this;
            aMedico.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void valorAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            valorMedico.MdiParent = this;
            valorMedico.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void registrarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCitas.MdiParent = this;
            rCitas.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void citasIncumplidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incumplidas.MdiParent = this;
            incumplidas.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void mostrarPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pacienter.MdiParent = this;
            pacienter.Show();
            aPaciente.Hide();
            rpaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSesion.Show();
        }

        private void mostrarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            medicor.MdiParent = this;
            medicor.Show();
            aPaciente.Hide();
            rpaciente.Hide();
            citasP.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            pacienter.Hide();
        }

        private void mostrarMultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multas.MdiParent = this;
            multas.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            citasP.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }

        private void mostarCitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            citasP.MdiParent = this;
            citasP.Show();
            rpaciente.Hide();
            aPaciente.Hide();
            multas.Hide();
            rmedico.Hide();
            aMedico.Hide();
            valorMedico.Hide();
            rCitas.Hide();
            incumplidas.Hide();
            medicor.Hide();
            pacienter.Hide();
        }
    }
}
