using ClubDeportivoWinForms.Views;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ClubDeportivoWinForms
{
    public partial class LoginView : GradientBackgroundCustom
    {
        private int clickPassCount = 0;

        public LoginView()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            button1.FlatAppearance.BorderSize = 0;
        }

        private void textBox_pass_Click(object sender, EventArgs e)
        {
            if (clickPassCount < 1)
            {
                textBox_pass.PasswordChar = '*';
                clickPassCount++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool validarNombre = Validaciones.isString(textBox_usuario.Text);
            bool validarPass = Validaciones.isNumeric(textBox_pass.Text);

            if (validarNombre && validarPass)
            {
                int pass = int.Parse(textBox_pass.Text);
                string name = textBox_usuario.Text;



                DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
                Data.Users dato = new Data.Users(); // variable que contiene todas las caracteristicas de la clase
                tablaLogin = dato.Log_Usu(textBox_usuario.Text, textBox_pass.Text);

                textBox_usuario.Text = string.Empty;
                textBox_pass.Text = string.Empty;

                if (tablaLogin.Rows.Count > 0)
                {
                    // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                    int userRol = int.Parse(s: tablaLogin.Rows[0][1].ToString());
                    int id = int.Parse(s: tablaLogin.Rows[0][2].ToString());


                    this.Hide();

                    //Aqui hacemos una comprobacion del rol del usuario
                    //si el rol del usuario es 120 se nos va a abrir la vista de administrador, de lo contraro
                    //se va a abrir la vista de usuario
                    //Y acá hay que agregar una tercera opción de no socio, que redirija a esa bista
                    switch (userRol)
                    {
                        case 120:
                            Form formAdmin = new AdminView();
                            //abre un dialogo que freeza el primer form y se va a ejecutar el f2
                            formAdmin.ShowDialog();
                            formAdmin = null;
                            break;

                        case 121:
                        case 122:
                            Form formUser = new UserView(id, userRol);
                            formUser.ShowDialog();
                            formUser = null;
                            break;
                    }

                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o password incorrecto");
                }
            }
            else
            {
                MessageBox.Show("Hay un error con alguno de los valores ingresados, recordá que la contraseña debe ser un número");
            }
        }

        private void textBox_pass_Enter(object sender, EventArgs e)
        {
            textBox_pass.PasswordChar = '*';
            clickPassCount++;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form forrmRegister = new RegisterView();
            forrmRegister.ShowDialog();
            forrmRegister = null;
        }

        private void LoginView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}