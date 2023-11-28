using MySql.Data.MySqlClient;
using System.Collections.Specialized;
using System.Configuration;

namespace ClubDeportivoWinForms.Data
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

        private NameValueCollection appSettings = ConfigurationManager.AppSettings;

        private Conexion() // asignamos valores a las variables de la conexion
        {
            this.baseDatos = ConfigurationManager.AppSettings["baseDatos"];
            this.servidor = ConfigurationManager.AppSettings["servidor"];
            this.puerto = ConfigurationManager.AppSettings["puerto"];
            this.usuario = ConfigurationManager.AppSettings["usuario"];
            this.clave = ConfigurationManager.AppSettings["clave"];
            //Hay un archivo app.config que tiene git ignore
            //cuando ejecuten el programa poner acá los valores
            //correspondientes a su base de datos :)
        }

        // proceso de interacción

        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}