using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoWinForms
{
    public partial class UserView : Form
    {
        public UserView()
        {
            InitializeComponent();
        }

        // Private field to store the idPersona value
        private int _idPersona;

        // Public property to access _idPersona
        public int IdPersona
        {
            get { return _idPersona; }
            set { _idPersona = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
