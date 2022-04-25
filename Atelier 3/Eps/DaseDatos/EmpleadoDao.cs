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
    public class EmpleadoDao
    {
        dataBase conectar = new dataBase();
        public int RegistrarEmpleado(Empleado empleado)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "INSERT INTO tbEmpleado(Cedula, Nombre, Apellido, Contrasena) VALUES(" +
                empleado.ECedula + ", '" + empleado.ENombre + "', '" +
                empleado.EApellido + "', '" + empleado.EContraseña + "')";

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int rEmpleado;

            rEmpleado = command.ExecuteNonQuery();

            sqlConnection.Close();

            return rEmpleado;
        }

        public DataSet Autentificar(int Cedula, String Contraseña)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT Cedula, Contrasena  FROM tbEmpleado " +
                "WHERE Cedula = '" + Cedula + "' and " +
                "Contrasena = '" + Contraseña + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Iniciar");
            sqlConnection.Close();

            return dataSet;
        }

        public DataSet BuscarEmpleado(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT Cedula FROM tbEmpleado " +
                "WHERE Cedula = '" + Cedula +  "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "BuscarE");
            sqlConnection.Close();

            return dataSet;
        }
    }
}
