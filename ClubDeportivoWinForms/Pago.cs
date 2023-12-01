namespace ClubDeportivoWinForms
{
    internal abstract class Pago
    {
        private int? id_pago;
        private DateTime fecha_pago;
        private DateTime fecha_vencimiento;
        private int costo;
        private int id_pers;

        public Pago(int? id_pago, DateTime fecha_pago, DateTime fecha_vencimiento, int costo, int id_pers)
        {
            this.id_pago = id_pago;
            this.fecha_pago = fecha_pago;
            this.fecha_vencimiento = fecha_vencimiento;
            this.costo = costo;
            this.id_pers = id_pers;
        }

        public int? Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public DateTime Fecha_vencimiento { get => fecha_vencimiento; set => fecha_vencimiento = value; }
        public int Costo { get => costo; set => costo = value; }
        public int Id_pers { get => id_pers; set => id_pers = value; }
        


    }
}