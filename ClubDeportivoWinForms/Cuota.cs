using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoWinForms
{
    internal class Cuota : Pago
    {

        private int? id_pago;
        private DateTime fecha_pago;
        private DateTime fecha_vencimiento;
        private int costo;
        private int id_pers;
        public Cuota(int? id_pago, DateTime fecha_pago, DateTime fecha_vencimiento, int costo, int intervalo, int id_pers) : base(id_pago, fecha_pago, fecha_vencimiento, costo, id_pers)
        {
            this.id_pago = id_pago;
        }

        public int? Id_pago { get => id_pago; set => id_pago = value; }
        public int Id_pers { get => id_pers; set => id_pers = value; }


        public void efectuarPago(int intervalo, long costo, int id) {
            
            DataTable tablaCuota = new DataTable();
            Data.Cuotas dato = new Data.Cuotas();
            tablaCuota = dato.PayCuota(intervalo, costo, true, id);

            //aqui traemos desde la base de datos el id generado por Mysql y lo seteamos como el id del socio
            if (tablaCuota.Rows[0][0].ToString() != null || tablaCuota.Rows[0][0].ToString() != string.Empty)
            {
                id_pago = int.Parse(tablaCuota.Rows[0][0].ToString());
            }
        }


    }
}
