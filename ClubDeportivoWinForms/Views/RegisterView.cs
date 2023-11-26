using ClubDeportivoWinForms.Views;
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
    public partial class RegisterView : GradientBackgroundCustom
    {
        public RegisterView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            registrar.FlatAppearance.BorderSize = 0;
        }
        private void registrar_Click(object sender, EventArgs e)
        {
            bool validarNombre = Validaciones.isString(textBox_Nombre.Text);
            bool validarTel = Validaciones.isNumeric(textBox_Telefono.Text);
            bool validarDni = Validaciones.isNumeric(textBox_DNI.Text);

            if (validarNombre && validarTel && validarDni)
            {
                int dni = int.Parse(textBox_DNI.Text);
                string name = textBox_Nombre.Text;
                long tel = long.Parse(textBox_Telefono.Text);

                Administrador admin = Administrador.GetInstance();

                if (checkBox1.Checked)
                {
                    // Perform action when checkBox1 is checked (true)
                    admin.crearSocio(null, name, tel, dni);

                }
                else if (!checkBox1.Checked)
                {
                    admin.crearNoSocio(null, name, tel, dni);
                 //aca creamos el no socio
                }

                textBox_DNI.Text = string.Empty;
                textBox_Nombre.Text = string.Empty;
                textBox_Telefono.Text = string.Empty;
                checkBox1.Checked = false;

                this.Hide();
                Form formLogin = new LoginView();
                formLogin.ShowDialog();
                formLogin = null;

            } else
            {
                MessageBox.Show("Hay un error con alguno de los valores ingresados, recordá que todos los campos son obligatorios y que el dni debe ser ingresado sin puntos");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLogin = new LoginView();
            formLogin.ShowDialog();
            formLogin = null;
        }

        private void RegisterView_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
