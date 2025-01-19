using System.Configuration;
//using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Microsoft.Data.SqlClient;

namespace Event_Mangement_System
{
    public partial class AdminSignup : Form

    {
        String pattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public AdminSignup()
        {
            InitializeComponent();
        }

        private void AdminSignup_Load(object sender, EventArgs e)
        {

        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(email.Text, pattern) == false)
            {
                email.Focus();
                errorProvider2.SetError(this.email, "Invalid email.");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) == true)
            {
                name.Focus();
                errorProvider1.SetError(this.name, "This field is mandatory*");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verify that all fields are filled
            if (string.IsNullOrWhiteSpace(key.Text) || string.IsNullOrWhiteSpace(name.Text) ||
                string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("Please fill in all fields before registering.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (key.Text == "7886")
            {
                String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                String query = "insert into adminlogin values(@name,@email,@pass)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@pass", pass.Text);

                try
                {
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registration failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid key entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignIN adminsignin = new AdminSignIN();
            adminsignin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminSignIN adminsignin = new AdminSignIN();
            adminsignin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignIn adminsignin = new CustomerSignIn();
            adminsignin.Show();
        }
    }
}
