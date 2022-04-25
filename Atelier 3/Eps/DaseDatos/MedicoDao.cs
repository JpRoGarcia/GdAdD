using Eps.Usuario;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eps.DaseDatos
{
    public class MedicoDao
    {
        dataBase conectar = new dataBase();

        public int RegistrarMedico(Medico medico)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "INSERT INTO tbMedico(Cedula, Nombre, Apellido, Especializacion, SalarioCita, AñosExperiencia) VALUES(" +
                medico.MCedula + ", '" + medico.MNombre + "', '" +
                medico.MApellido + "', '" + medico.MEspecialidad + "', '" +
                medico.MValorSalario + "', '" + medico.MAñosExperiencia + "')";

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int rMedico;

            rMedico = command.ExecuteNonQuery();

            sqlConnection.Close();

            return rMedico;
        }

        public int ActualizarMedico(int CedulaM, string nombre, string salarioCita)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "UPDATE tbMedico SET Nombre = '" + nombre + "', SalarioCita = '" + salarioCita +
                "' WHERE Cedula = " + CedulaM;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;

        }

        public DataSet MostrarValor(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT Cedula, Especializacion, SalarioCita FROM tbMedico " +
                "WHERE Cedula = '" + Cedula + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Medico");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet BuscarMedico(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT Cedula FROM tbMedico " +
                "WHERE Cedula = '" + Cedula + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "BuscarM");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet MostrarMedico()
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT * FROM tbMedico";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "MostrarMed");
            sqlConnection.Close();

            return dataSet;
        }

        public int EliminarMedico(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "DELETE FROM tbMedico WHERE Cedula = " + Cedula;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;
        }
    }
}
