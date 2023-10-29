using System.Data;


namespace ClubDeportivoWinForms
{
    public partial class LoginView : Form
    {
        private int clickPassCount = 0;


        public LoginView()
        {
            InitializeComponent();

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
                        // en el caso de que se cree un usuario, en realidad hay que redirigir a la pantalla
                        // de pago, porque al realizar el registro hay necesariamente que pagar
                        Form formUser = new UserView();
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
            this.Show();
        }
    }
}