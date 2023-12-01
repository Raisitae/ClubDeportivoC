using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{
    internal class Socio : Persona
    {

        private int? id_socio;
        public Socio(int? id_socio, string name, long num_Telefono, int dni) : base(name, num_Telefono, dni)
        {
            this.id_socio = id_socio;
        }
        public int? Id_socio { get => id_socio; set => id_socio = value; }

        public bool registrarSocio(string nombre, long telefono, int dni){

            //implementamos el registro del socio en la base de datos
            DataTable tablaCreate = new DataTable(); 
            Data.Personas dato = new Data.Personas();
            tablaCreate = dato.CreatePersona(nombre, telefono, dni, 121);

            //aqui traemos desde la base de datos el id generado por Mysql y lo seteamos como el id del socio
            if (tablaCreate.Rows[0][0].ToString() != null || tablaCreate.Rows[0][0].ToString() != string.Empty)
            {
                id_socio = int.Parse(tablaCreate.Rows[0][0].ToString());
            }
            return true;
        }

        public override string ToString()
        {
            return Id_socio.ToString() + Name.ToString() + Dni.ToString();
        }


    }

}
