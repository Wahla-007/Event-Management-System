using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Event_Mangement_System
{
    public partial class AddEventCustomer : Form
    {
        private String email;

        public AddEventCustomer(String e)
        {
            InitializeComponent();
            email = e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values from user input
            int balloon = 0;
            int employee = 0;
            int invoice = 0;

            // Try parsing to integers to avoid errors when parsing text input



            // Set up the connection string and SQL query
            String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            String query = "INSERT INTO EventDetails (Email, EventDate, EventTime, EventPlace, EventCompany, BalloonQuantity, Employees, Invoice, Details) " +
                           "VALUES (@Email, @Date, @Time, @Place, @Company, @Balloon, @Employee, @Invoice, @Details)";

            SqlCommand cmd = new SqlCommand(query, con);

            // Add parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Date", date.Text);   // Assuming `dateTextBox` contains the event date
            cmd.Parameters.AddWithValue("@Time", timee.Text);   // Assuming `timeTextBox` contains the event time
            cmd.Parameters.AddWithValue("@Place", place.Text); // Assuming `placeTextBox` contains the event place
            cmd.Parameters.AddWithValue("@Company", company.Text); // Assuming `companyTextBox` contains the event company name
            cmd.Parameters.AddWithValue("@Balloon", balloon);
            cmd.Parameters.AddWithValue("@Employee", employee);
            cmd.Parameters.AddWithValue("@Invoice", invoice);
            cmd.Parameters.AddWithValue("@Details", details.Text); // Assuming `detailsTextBox` contains additional details

            try
            {
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    CustomerMenu menu = new CustomerMenu(email);
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CustomerMenu m1 = new CustomerMenu(email);
            m1.Show();
        }
    }
}
