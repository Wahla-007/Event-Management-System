using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Event_Mangement_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    CustomerSignup adminsignin = new CustomerSignup();
        //    adminsignin.Show();

        //}

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerSignIn adminsignin = new CustomerSignIn();
            adminsignin.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CustomerSignIn adminsignin = new CustomerSignIn();
            adminsignin.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminSignIN adminsignin = new AdminSignIN();
            adminsignin.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String alam = name.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            String query = "insert into detailsCustomer values(@name,@email,@pass)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);

            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Reistered!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Reistration failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }
    }
}
