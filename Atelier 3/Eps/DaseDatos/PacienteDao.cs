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
    class PacienteDao
    {
        dataBase conectar = new dataBase();

        public int RegistrarPaciente(Paciente paciente)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "INSERT INTO tbPaciente(Cedula, Nombre, Apellido, FechaNacimiento, Direcion, Email, Telefono, FechaRegistro, PazySalvo) VALUES(" +
                paciente.PNumeroID + ", '" + paciente.PNombre + "', '" +
                paciente.PApellido + "', '" + paciente.PFechaNacimiento + "', '" +
                paciente.PDireccion + "', '" + paciente.PEmail + "', '" +
                paciente.PTelefono + "', '" + paciente.PRegistro + "', '" + paciente.PPazySalvo + "')";

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int rPaciente;

            rPaciente = command.ExecuteNonQuery();

            sqlConnection.Close();

            return rPaciente;
        }

        public int actualizarPaciente(int Cedula, string Email, string Direccion, string Telefono)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "UPDATE tbPaciente SET Email = '" + Email + "', Direcion = '" + Direccion + "', Telefono = '" + Telefono + "' WHERE Cedula = " + Cedula;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;
        }

        public int actualizarPazySalvo(int Cedula, String PazySalvo)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "UPDATE tbPaciente SET PazySalvo = '" + PazySalvo + "' WHERE Cedula = " + Cedula;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;
        }

        public DataSet BuscarPaciente(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT Cedula FROM tbPaciente " +
                "WHERE Cedula = '" + Cedula + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "BuscarP");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet MostrarPaciente()
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT * FROM tbPaciente";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "MostrarP");
            sqlConnection.Close();

            return dataSet;
        }

        public int EliminarPaciente(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "DELETE FROM tbPaciente WHERE Cedula = " + Cedula;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();

            return registros;
        }


    }
}
