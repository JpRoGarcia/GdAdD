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
    public partial class CitasIncumplidas : Form
    {
        CitaDao citaDao = new CitaDao();
        public CitasIncumplidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Incumplidas = "No Asistio";

            DataSet dataSetM = new DataSet();
            dataSetM = citaDao.MostrarIncumplidas(Incumplidas);
            dgvMCI.DataSource = dataSetM.Tables["CitaIncumplida"];
        }
    }
}
