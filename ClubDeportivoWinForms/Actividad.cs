using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{
    internal class Actividad : Pago
    {
        private int? id_pago;
        private DateTime fecha_pago;
        private DateTime fecha_vencimiento;
        private int costo;
        private int id_pers;

        public Actividad(int? id_pago, DateTime fecha_pago, DateTime fecha_vencimiento, int costo, int id_pers) : base(id_pago, fecha_pago, fecha_vencimiento, costo, id_pers)
        {
            this.id_pago = id_pago;
        }

        public int? Id_pago { get => id_pago; set => id_pago = value; }

       
        public void efectuarPago(long costo, int id)
        {
            DataTable tablaActividad = new DataTable();
            Data.Cuotas dato = new Data.Cuotas();
            tablaActividad = dato.PayActividad(costo, id);

            if (tablaActividad.Rows[0][0].ToString() != null || tablaActividad.Rows[0][0].ToString() != string.Empty)
            {
                id_pago = int.Parse(tablaActividad.Rows[0][0].ToString());
            }
        }


    }
}