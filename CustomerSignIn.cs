using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
namespace Event_Mangement_System
{
    public partial class CustomerSignIn : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public CustomerSignIn()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignIN adminsignin = new AdminSignIN();
            adminsignin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignIn adminsignin = new CustomerSignIn();
            adminsignin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 adminsignin = new Form1();
            adminsignin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(es);
            String query = "select * from detailsCustomer where email=@email and password=@pass";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {

                this.Hide();
                //MessageBox.Show("Successful!");
                CustomerMenu menu = new CustomerMenu(email.Text);
                menu.Show();



            }
            else
            {
                MessageBox.Show("Login Failed!!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                email.Clear();
                pass.Clear();
                email.Focus();
            }
            con.Close();
        }
    }
}
