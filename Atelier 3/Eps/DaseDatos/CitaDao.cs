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
    public class CitaDao
    {
        dataBase conectar = new dataBase();
        public int RegistrarCita(Cita cita)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "INSERT INTO tbCita(TipoCita, CedulaPaciente, CedulaMedico, FechaCita, EstadoCita) VALUES('"   + cita.CTipoCita + "', " +
                cita.CCedulaP + ", " + cita.CCedulaM + ", '" +
                cita.CFecha + "', '" + cita.CEstado + "')";

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int rEmpleado;

            rEmpleado = command.ExecuteNonQuery();

            sqlConnection.Close();

            return rEmpleado;
        }

        public int ActualizarEstadoCita(int idCita, String Estado)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "UPDATE tbCita SET EstadoCita = '" + Estado + "' WHERE IdCita = " + idCita;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;
        }

        public DataSet MostrarCitaP(int Cedula, String Estado)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "SELECT IdCita, CedulaPaciente, CedulaMedico, FechaCita, EstadoCita FROM tbCita " +
                "WHERE CedulaPaciente = '" + Cedula + "' and " +
                "EstadoCita = '" + Estado + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "CitaPaciente");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet MostrarIncumplidas(String Estado)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT CedulaPaciente, TipoCita, FechaCita FROM tbCita " +
                "WHERE EstadoCita = '" + Estado + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "CitaIncumplida");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet MostarTipoCita(int Cedula, String Tipo, String Estado)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT CedulaPaciente, TipoCita, EstadoCita FROM tbCita " +
                "WHERE CedulaPaciente = '" + Cedula + "' and " +
                "TipoCita = '" + Tipo + "' and " +
                "EstadoCita = '" + Estado + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "TipoCita");
            sqlConnection.Close();

            return dataSet;
        }

        public int EliminarCita(int Id)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "DELETE FROM tbCita WHERE IdCita = " + Id;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();
            return registros;
        }
    }
}
