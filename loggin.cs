using Microsoft.Win32;

namespace Skill_IS_System
{
    public partial class loggin : Form
    {
        public loggin()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == " " && password.Text == " ")
                {
                    MessageBox.Show("Missing Infirmation");
                }
                else if (username.Text == "admin" && password.Text == "admin")
                {
                    registration home = new registration();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please enter the correct Username and Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }
    }
}