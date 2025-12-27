using Gym_Management.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        List<GymUser> users = new List<GymUser>()
        {
            new GymUser() { Username = "admin", Password = "1234", Role = "Admin" },
            new GymUser() { Username = "client", Password = "abcd", Role = "Client" }
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            GymUser user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)
            {
                MessageBox.Show($"Bine ai venit, {user.Role}!");
                this.Hide();
                if (user.Role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    ClientForm clientForm = new ClientForm();
                    clientForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Username sau parola incorectã!");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
