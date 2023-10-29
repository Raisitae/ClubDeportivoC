using ClubDeportivoWinForms.Views;

namespace ClubDeportivoWinForms
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void listPrueba_click(object sender, EventArgs e)
        {
            Form formUsers = new userList();
            formUsers.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminView_Activated(object sender, EventArgs e)
        {
        }
    }
}