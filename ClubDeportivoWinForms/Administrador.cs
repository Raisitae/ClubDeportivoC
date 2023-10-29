using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClubDeportivoWinForms
{
    internal class Administrador
    {
       


        public Administrador() {

        }

        public bool crearSocio(int? id_socio, string name, long num_Telefono, int dni)
        {


            DataTable tablaCheck = new DataTable();
            Data.Socios dato = new Data.Socios();
            tablaCheck = dato.CheckSocio(dni);
            int resultado = int.Parse(tablaCheck.Rows[0][0].ToString());
            if (resultado == 0)
            {
                Socio socio = new Socio(null, name, num_Telefono, dni);
                socio.registrarSocio(name, num_Telefono, dni);
                MessageBox.Show(socio.ToString());
            } else
            {
                MessageBox.Show("El socio ya se encuentra en nuestra base de datos");
            }

            return true;

        }

        
        //esto va a ir desde el usuario
        public bool pagarCuota(int id_pago, DateTime fecha_pago, bool vencido, int costo, bool mensual)
        {
            Cuota cuota = new Cuota(id_pago, DateTime.Now, vencido, costo, mensual);

            //aca hariamos cuota.pagarCuota() y lo mandamos a la database
            return true;
        }


    }
}
