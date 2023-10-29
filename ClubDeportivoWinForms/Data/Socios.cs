using MySql.Data.MySqlClient;
using System.Data;

namespace ClubDeportivoWinForms.Data
{
    internal class Socios
    {
        // creamos un metodo que retorne una tabla con la informacion
        public DataTable All_socios()
        {
            MySqlDataReader resultado; // variable de tipo datareader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand
                ("socio", sqlCon);

                //TableDirect nos permite traer toda la tabla socio
                comando.CommandType = CommandType.TableDirect;

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

        public DataTable CreateSocio(string N_socio, long Num_socio, int D_socio)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand
                ("addSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //en este caso estamos usando un StoreProcedure porque queremos hacer varias cosas:
                //por un lado estamos insertando los valores en socio
                //tambien estamos en la base de datos creando un usuario
                //y finalmente estamos obteniendo el id generado por la base de datos

                comando.Parameters.Add("nombre",
                MySqlDbType.VarChar).Value = N_socio;
                comando.Parameters.Add("num_telefono", MySqlDbType.Int64).Value =
                Num_socio;
                comando.Parameters.Add("thisdni", MySqlDbType.Int64).Value =
                D_socio;

                sqlCon.Open();
                resultado = comando.ExecuteReader(); // almacenamos el resultado en la variable
                tabla.Load(resultado); // cargamos la tabla con el resultado
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

        public DataTable CheckSocio(int D_socio)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();

                MySqlCommand comando = new MySqlCommand
                ("checkSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                //El store procedure es simple, quizas podria resumirse a un CommandType.Text
                //Pero son mas susceptibles a query injections;

                comando.Parameters.Add("thisdni", MySqlDbType.Int64).Value =
                D_socio;

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