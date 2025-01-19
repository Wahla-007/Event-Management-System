
using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
//using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
namespace Event_Mangement_System
{
    public partial class UpdateEventAdmin : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public UpdateEventAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Field Validation
            if (string.IsNullOrWhiteSpace(id.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(date.Text) ||
                string.IsNullOrWhiteSpace(timee.Text) ||
                string.IsNullOrWhiteSpace(place.Text) ||
                string.IsNullOrWhiteSpace(company.Text) ||
                string.IsNullOrWhiteSpace(baloon.Text) ||
                string.IsNullOrWhiteSpace(employee.Text) ||
                string.IsNullOrWhiteSpace(invoice.Text) ||
                string.IsNullOrWhiteSpace(detail.Text))
            {
                MessageBox.Show("Please fill in all fields before updating the event.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);

            // SQL query to update event details
            String query = "UPDATE EventDetails " +
                           "SET Email=@email, EventDate=@date, EventTime=@time, EventPlace=@place, " +
                           "EventCompany=@company, BalloonQuantity=@baloon, Employees=@employee, " +
                           "Invoice=@invoice, Details=@detail " +
                           "WHERE EventID=@Eventid";

            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters for the query
            cmd.Parameters.AddWithValue("@Eventid", id.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@date", date.Text);
            cmd.Parameters.AddWithValue("@time", timee.Text);
            cmd.Parameters.AddWithValue("@place", place.Text);
            cmd.Parameters.AddWithValue("@company", company.Text);
            cmd.Parameters.AddWithValue("@baloon", baloon.Text);
            cmd.Parameters.AddWithValue("@employee", employee.Text);
            cmd.Parameters.AddWithValue("@invoice", invoice.Text);
            cmd.Parameters.AddWithValue("@detail", detail.Text);

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    AdminMenu menu = new AdminMenu();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Update failed. Please check the Event ID.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu c1 = new AdminMenu();
            c1.Show();
        }
    }
}
