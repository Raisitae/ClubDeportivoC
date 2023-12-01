using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{
    internal class Nosocio : Persona
    {
        private int? id_nosocio;

        public Nosocio(int? id_nosocio, string name, long num_Telefono, int dni) : base(name, num_Telefono, dni)
        {
            this.id_nosocio = id_nosocio;
        }
        public int? Id_nosocio { get => id_nosocio; set => id_nosocio = value; }

        public bool registrarNoSocio(string nombre, long telefono, int dni)
        {
            //implementamos el registro del no socio en la base de datos
            DataTable tablaCreate = new DataTable();
            Data.Personas dato = new Data.Personas();
            tablaCreate = dato.CreatePersona(nombre, telefono, dni, 122);

            //aqui traemos desde la base de datos el id generado por Mysql y lo seteamos como el id del socio
            if (tablaCreate.Rows[0][0].ToString() != null || tablaCreate.Rows[0][0].ToString() != string.Empty)
            {
                id_nosocio = int.Parse(tablaCreate.Rows[0][0].ToString());
            }

            return true;
        }
    }
}
