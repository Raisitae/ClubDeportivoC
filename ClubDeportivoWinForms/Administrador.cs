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
        private static Administrador instance;
        public static Administrador GetInstance()
        {
            if (instance == null)
            {
                instance = new Administrador();
            }
            return instance;
        }


        public bool crearSocio(int? id_socio, string name, long num_Telefono, int dni)
        {


            DataTable tablaCheck = new DataTable();
            Data.Personas dato = new Data.Personas();
            tablaCheck = dato.CheckSocio(dni);
            int resultado = int.Parse(tablaCheck.Rows[0][0].ToString());
            if (resultado == 0)
            {
                Socio socio = new Socio(null, name, num_Telefono, dni);
                socio.registrarSocio(name, num_Telefono, dni);
                MessageBox.Show("Socio creado exitosamente!, para continuar, inicie sesión");
            }
            else
            {
                MessageBox.Show("El socio ya se encuentra en nuestra base de datos");
            }

            return true;

        }

        public bool crearNoSocio(int? id_socio, string name, long num_Telefono, int dni)
        {
            DataTable tablaCheck = new DataTable();
            Data.Personas dato = new Data.Personas();
            tablaCheck = dato.CheckSocio(dni); //esto cambiar a Checkpersona
            int resultado = int.Parse(tablaCheck.Rows[0][0].ToString());
            if (resultado == 0)
            {
                Nosocio nosocio = new Nosocio(null, name, num_Telefono, dni);
                nosocio.registrarNoSocio(name, num_Telefono, dni);
                MessageBox.Show("No socio creado exitosamente!, para continuar, inicie sesión");
            }
            else
            {
                MessageBox.Show("El no socio ya se encuentra en nuestra base de datos");
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
