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
        public void crearCouta(int costo, int intervalo, int id) {
            DateTime currentDateTime = DateTime.Now;

            Cuota cuota = new Cuota(null, currentDateTime, currentDateTime.AddMonths(intervalo), costo * intervalo, intervalo, id);
            cuota.efectuarPago(intervalo, costo * intervalo, id);
            MessageBox.Show("Pago efectuado!");
        }

        public void crearActividad(int costo, int id)
        {   DateTime currentDateTime = DateTime.Now;

            Actividad actividad = new Actividad(null, currentDateTime, currentDateTime.AddDays(1), costo, id);
            actividad.efectuarPago(costo, id);
            MessageBox.Show("Pago efectuado!");
        }



    }
}
