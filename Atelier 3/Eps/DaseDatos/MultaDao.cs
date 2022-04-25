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
    public class MultaDao
    {
        dataBase conectar = new dataBase();
        public int RegistrarMulta(Multa multa)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "INSERT INTO tbMulta(CedulaP, ValorMulta) VALUES(" + 
                multa.MCedulaP + ", " + multa.MValorMulta + ")";

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);

            int rEmpleado;

            rEmpleado = command.ExecuteNonQuery();

            sqlConnection.Close();

            return rEmpleado;
        }

        public int EliminarMulta(int idMulta)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);

            String query = "DELETE FROM tbMulta " +
                "WHERE idMulta = " + idMulta;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            int registros;

            registros = command.ExecuteNonQuery();

            sqlConnection.Close();
            return registros;
        }

        public DataSet MostrarMulta(int Cedula)
        {
            SqlConnection sqlConnection = new SqlConnection(conectar.conexion);
            String query = "SELECT idMulta, CedulaP, ValorMulta FROM tbMulta " +
                "WHERE CedulaP = '" + Cedula + "'";

            sqlConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Multa");
            sqlConnection.Close();

            return dataSet;
        }


    }
}
