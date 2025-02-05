using System;
using System.Data.SqlClient; // Ensure this is included
using System.Windows.Forms;
using System.Configuration;

namespace Skill_IS_System
{
    public partial class registration : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["StudentDB"].ConnectionString;

        public registration()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

        }

        private void regno_Leave(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Students WHERE RegNo = @RegNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    fname.Text = reader["FirstName"].ToString();
                    lname.Text = reader["LastName"].ToString();
                    if (reader["Gender"].ToString() == "Male")
                        rmale.Checked = true;
                    else
                        rfemale.Checked = true;
                    address.Text = reader["Address"].ToString();
                    email.Text = reader["Email"].ToString();
                    mphone.Text = reader["MobilePhone"].ToString();
                    hphone.Text = reader["HomePhone"].ToString();
                    pname.Text = reader["ParentName"].ToString();
                    nic.Text = reader["NIC"].ToString();
                    cnumber.Text = reader["ContactNumber"].ToString();
                    dob.Value = Convert.ToDateTime(reader["DoB"]);
                }
                else
                {
                    MessageBox.Show("No record found with this Registration Number");
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }

        private void clear_Click_1(object sender, EventArgs e)
        {
            regno.Clear();
            fname.Clear();
            lname.Clear();
            rmale.Checked = false;
            rfemale.Checked = false;
            address.Clear();
            email.Clear();
            mphone.Clear();
            hphone.Clear();
            pname.Clear();
            nic.Clear();
            cnumber.Clear();
            dob.Value = DateTime.Now;
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Students WHERE RegNo = @RegNo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted");
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string gender = rmale.Checked ? "Male" : "Female";

                string query = "UPDATE Students SET FirstName=@FirstName, LastName=@LastName, Gender=@Gender, Address=@Address, Email=@Email, " +
                               "MobilePhone=@MobilePhone, HomePhone=@HomePhone, ParentName=@ParentName, NIC=@NIC, ContactNumber=@ContactNumber, DoB=@DoB WHERE RegNo=@RegNo";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);
                cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                cmd.Parameters.AddWithValue("@LastName", lname.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@MobilePhone", mphone.Text);
                cmd.Parameters.AddWithValue("@HomePhone", hphone.Text);
                cmd.Parameters.AddWithValue("@ParentName", pname.Text);
                cmd.Parameters.AddWithValue("@NIC", nic.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", cnumber.Text);
                cmd.Parameters.AddWithValue("@DoB", dob.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Successful");
            }
        }

        private void register_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string gender = rmale.Checked ? "Male" : "Female";

                string query = "INSERT INTO Students (RegNo, FirstName, LastName, Gender, Address, Email, MobilePhone, HomePhone, ParentName, NIC, ContactNumber, DoB) " +
                               "VALUES (@RegNo, @FirstName, @LastName, @Gender, @Address, @Email, @MobilePhone, @HomePhone, @ParentName, @NIC, @ContactNumber, @DoB)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RegNo", regno.Text);
                cmd.Parameters.AddWithValue("@FirstName", fname.Text);
                cmd.Parameters.AddWithValue("@LastName", lname.Text);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Address", address.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@MobilePhone", mphone.Text);
                cmd.Parameters.AddWithValue("@HomePhone", hphone.Text);
                cmd.Parameters.AddWithValue("@ParentName", pname.Text);
                cmd.Parameters.AddWithValue("@NIC", nic.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", cnumber.Text);
                cmd.Parameters.AddWithValue("@DoB", dob.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");
            }
          
        }
    }
}
