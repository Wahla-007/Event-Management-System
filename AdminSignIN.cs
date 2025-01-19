using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace Event_Mangement_System
{
    public partial class AdminSignIN : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminSignIN()
        {
            InitializeComponent();
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
            AdminSignup adminsignup = new AdminSignup();
            adminsignup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignIn customersignin = new CustomerSignIn();
            customersignin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Verify that all fields are filled
            if (string.IsNullOrWhiteSpace(email.Text) || string.IsNullOrWhiteSpace(pass.Text))
            {
                MessageBox.Show("Please fill in all fields before logging in.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection con = new SqlConnection(es);
            String query = "select * from adminlogin where email=@email and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);

            try
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    this.Hide();
                    // Open Admin Menu
                    AdminMenu menu = new AdminMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed! Please check your email and password.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    email.Clear();
                    pass.Clear();
                    email.Focus();
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


        private void forget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            forgetAdmin ForgetAdmin = new forgetAdmin();
            ForgetAdmin.Show(); 

        }
    }
}
