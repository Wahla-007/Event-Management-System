using System.Configuration;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Event_Mangement_System
{
    public partial class AddEventAdmin : Form
    {
        public AddEventAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = email.Text.Trim();
            string dateInput = date.Text.Trim();
            string timeInput = Timee.Text.Trim();
            string placeInput = place.Text.Trim();
            string companyInput = company.Text.Trim();
            string balloonInput = baloon.Text.Trim();
            string employeeInput = employee.Text.Trim();
            string invoiceInput = invoice.Text.Trim();
            string detailInput = detail.Text.Trim();

            if (string.IsNullOrEmpty(emailInput) || string.IsNullOrEmpty(dateInput) || string.IsNullOrEmpty(timeInput) ||
                string.IsNullOrEmpty(placeInput) || string.IsNullOrEmpty(companyInput) || string.IsNullOrEmpty(balloonInput) ||
                string.IsNullOrEmpty(employeeInput) || string.IsNullOrEmpty(invoiceInput) || string.IsNullOrEmpty(detailInput))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(balloonInput, out int balloonQuantity) || balloonQuantity <= 0)
            {
                MessageBox.Show("Balloon Quantity must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(employeeInput, out int employeeCount) || employeeCount <= 0)
            {
                MessageBox.Show("Employees must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(invoiceInput, out decimal invoiceAmount) || invoiceAmount <= 0)
            {
                MessageBox.Show("Invoice must be a valid positive amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "INSERT INTO EventDetails (Email, EventDate, EventTime, EventPlace, EventCompany, BalloonQuantity, Employees, Invoice, Details) " +
                                   "VALUES (@Email, @EventDate, @EventTime, @EventPlace, @EventCompany, @BalloonQuantity, @Employees, @Invoice, @Details)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", emailInput);
                        cmd.Parameters.AddWithValue("@EventDate", dateInput);
                        cmd.Parameters.AddWithValue("@EventTime", timeInput);
                        cmd.Parameters.AddWithValue("@EventPlace", placeInput);
                        cmd.Parameters.AddWithValue("@EventCompany", companyInput);
                        cmd.Parameters.AddWithValue("@BalloonQuantity", balloonQuantity);
                        cmd.Parameters.AddWithValue("@Employees", employeeCount);
                        cmd.Parameters.AddWithValue("@Invoice", invoiceAmount);
                        cmd.Parameters.AddWithValue("@Details", detailInput);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminMenu menu = new AdminMenu();
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Event addition failed!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu m1 = new AdminMenu();
            m1.Show();
        }
    }
}
