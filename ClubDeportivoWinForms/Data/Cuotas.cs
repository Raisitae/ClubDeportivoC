using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivoWinForms.Data
{
    internal class Cuotas
    {
        public DataTable PayCuota(int I_intervalPago, long costo, bool mensual, int id)
        {
            MySqlDataReader resultado; // variable de tipo datareaderde
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("PayCuota", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("intervalPago",
                MySqlDbType.VarChar).Value = I_intervalPago;
                comando.Parameters.Add("thiscosto", MySqlDbType.Int64).Value =
                costo;
                comando.Parameters.Add("thisid", MySqlDbType.Int64).Value =
                id;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        public DataTable FetchUltimoPago(int thisid)
        {
            MySqlDataReader resultado; // variable de tipo datareaderde
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("FetchUltimoPago", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("idPers", MySqlDbType.Int64).Value =
                thisid;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        public DataTable FetchVencimientosDiarios()
        {
            MySqlDataReader resultado; // variable de tipo datareaderde
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("FetchVencimientosDiarios", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }

        public DataTable PayActividad(long costo, int dni)
        {
            MySqlDataReader resultado; // variable de tipo datareaderde
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("PayActividad", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("thiscosto", MySqlDbType.Int64).Value =
                costo;
                comando.Parameters.Add("thisid", MySqlDbType.Int64).Value =
                dni;

                sqlCon.Open();
                resultado = comando.ExecuteReader();
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
        }
    }
}