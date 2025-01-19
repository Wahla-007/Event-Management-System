using Microsoft.Data.SqlClient;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Configuration;
namespace Event_Mangement_System
{
    public partial class UpdateEventCustomer : Form
    {
        private String user;
        private int employ = 0;
        private int inv = 0;


        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public UpdateEventCustomer(String name)
        {
            InitializeComponent();
            user = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            String query = "update EventDetails set Email=@user,EventDate=@date,EventTime=@time,EventPlace=@place,EventCompany=@company,BalloonQuantity=@baloon,Employees=@employee,Invoice=@invoice,Details=@detail where EventID=@id and Email=@user";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@id", id.Text);
            cmd.Parameters.AddWithValue("@date", date.Text);
            cmd.Parameters.AddWithValue("@time", timee.Text);
            cmd.Parameters.AddWithValue("@place", place.Text);
            cmd.Parameters.AddWithValue("@employee", employ);
            cmd.Parameters.AddWithValue("@invoice", inv);
            cmd.Parameters.AddWithValue("@company", company.Text);
            cmd.Parameters.AddWithValue("@baloon", baloon.Text);
            
            cmd.Parameters.AddWithValue("@detail", detail.Text);


            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Event Updated Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                //MessageBox.Show("Successful!");
                CustomerMenu menu = new CustomerMenu(user);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Reistration failed!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CustomerMenu m1 = new CustomerMenu(user);
            m1.Show();
        }
    }

}
