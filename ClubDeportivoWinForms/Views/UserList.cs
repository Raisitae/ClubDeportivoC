using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoWinForms.Views
{
    public partial class userList : Form
    {
        public userList()
        {
            InitializeComponent();
            DataTable tablaSocios = new DataTable();
            Data.Socios dato = new Data.Socios(); // variable que contiene todas las caracteristicas de la clase
            tablaSocios = dato.All_socios();
            dataGridView1.DataSource = tablaSocios;

        }



    }
}
