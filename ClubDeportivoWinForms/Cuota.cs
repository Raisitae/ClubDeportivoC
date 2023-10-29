namespace ClubDeportivoWinForms
{
    internal class Cuota
    {
        private int id_pago;
        private DateTime fecha_pago;
        private bool vencido;
        private int costo;
        private bool mensual;

        public Cuota(int id_pago, DateTime fecha_pago, bool vencido, int costo, bool mensual)
        {
            this.id_pago = id_pago;
            this.fecha_pago = fecha_pago;
            this.vencido = vencido;
            this.costo = costo;
            this.mensual = mensual;
        }

        public int Id_pago { get => id_pago; set => id_pago = value; }
        public DateTime Fecha_pago { get => fecha_pago; set => fecha_pago = value; }
        public bool Vencido { get => vencido; set => vencido = value; }
        public int Costo { get => costo; set => costo = value; }
        public bool Mensual { get => mensual; set => mensual = value; }

        public bool pagarCuota()
        {
            Vencido = false;
            //conexion a la base de datos
            return Vencido;
        }

        public DateTime calcularProxVencimiento()
        {
            DateTime proxVencimiento = fecha_pago.AddMonths(1);
            return proxVencimiento;
        }

        private bool calcularVencimiento()
        {
            DateTime proxVencimiento = fecha_pago.AddMonths(1);
            return DateTime.Now < proxVencimiento ? true : false;
        }
    }
}