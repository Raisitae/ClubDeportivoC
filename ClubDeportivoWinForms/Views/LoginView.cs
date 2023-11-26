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
            this.Load += LoginView_Load; // Subscribe to the Load event
        }

        private void LoginView_Load(object? sender, EventArgs e)
        {
            // Set focus to another control, for example, a button
            // probablemente al placeholder van 

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
            //codigo brindado x la clase
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Data.Users dato = new Data.Users(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(textBox_usuario.Text, textBox_pass.Text);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                int userRol = int.Parse(s: tablaLogin.Rows[0][1].ToString());

                this.Hide();

                //Aqui hacemos una comprobacion del rol del usuario
                //si el rol del usuario es 120 se nos va a abrir la vista de administrador, de lo contraro
                //se va a abrir la vista de usuario
                //Y ac� hay que agregar una tercera opci�n de no socio, que redirija a esa bista
                switch (userRol)
                {
                    case 120:
                        Form formAdmin = new AdminView();
                        //abre un dialogo que freeza el primer form y se va a ejecutar el f2
                        formAdmin.ShowDialog();
                        formAdmin = null;
                        break;

                    case 121:
                        // en el caso de que se cree un usuario, en realidad hay que redirigir a la pantalla
                        // de pago, porque al realizar el registro hay necesariamente que pagar
                        Form formUser = new UserView();
                        formUser.ShowDialog();
                        formUser = null;
                        break;

                    case 122:
                        // en el caso de que se cree un usuario, en realidad hay que redirigir a la pantalla
                        // de pago, porque al realizar el registro hay necesariamente que pagar
                        Form formUser2 = new UserView();
                        formUser2.ShowDialog();
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