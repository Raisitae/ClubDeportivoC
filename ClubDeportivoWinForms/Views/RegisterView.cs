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
    public partial class RegisterView : Form
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void registrar_Click(object sender, EventArgs e)
        {
            int dni = int.Parse(textBox_DNI.Text);
            string name = textBox_Nombre.Text;
            long tel = long.Parse(textBox_Telefono.Text);
            Administrador admnin = new Administrador();

            //acá hay que implementar la logica de si el usuario es un socio
            // o un no socio
            // y en base a eso hacer un switch de case, para elegir entre uno y otro
            // y en la base de datos hay que modificar el store procedure
            // o crear otro distinto para los no socios, hay que ver
            admnin.crearSocio(null, name, tel, dni);

            textBox_DNI.Text = string.Empty;
            textBox_Nombre.Text = string.Empty;
            textBox_Telefono.Text = string.Empty;

            MessageBox.Show("Usuario creado exitosamente!, para continuar, inicie sesión");

            this.Close();
        }
    }
}
