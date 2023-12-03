using ClubDeportivoWinForms.Views;
using System.Data;

namespace ClubDeportivoWinForms
{
    public partial class AdminView : GradientBackgroundCustom
    {
        public AdminView()
        {
            InitializeComponent();
            buttonVenc.FlatAppearance.BorderSize = 0;
            buttonCerrar.FlatAppearance.BorderSize = 0;

        }

        private void AdminView_Activated(object sender, EventArgs e)
        {
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVenc_Click(object sender, EventArgs e)
        {
            DataTable tablaVenc = new DataTable();
            Data.Cuotas dato = new Data.Cuotas();
            tablaVenc = dato.FetchVencimientosDiarios();
            dataGridView1.DataSource = tablaVenc;
        }
    }
}