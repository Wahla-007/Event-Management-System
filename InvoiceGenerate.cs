using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace Event_Mangement_System
{
    public partial class InvoiceGenerate : Form
    {
        private String selectedID;
        private string eventEmail;
        public InvoiceGenerate(String hobbit, String email)
        {
            InitializeComponent();
            selectedID = hobbit;
            this.eventEmail = email;

        }




        private string GetCustomerName(string email)
        {
            string name = "";
            String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
            string query = "SELECT Name FROM DetailsCustomer WHERE Email = @Email";

            using (SqlConnection conn = new SqlConnection(es))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                try
                {
                    conn.Open();
                    var result = cmd.ExecuteScalar(); // Fetch the name
                    if (result != null)
                    {
                        name = result.ToString();
                    }
                    else
                    {
                        name = "Not Found"; // Default value if no result is returned
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return name;
        }




        private void LoadInvoiceData(string id)
        {
            try
            {
                // Database connection string
                String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                using (SqlConnection con = new SqlConnection(es))
                {
                    con.Open();

                    // SQL query to get the specific record
                    string query = "SELECT * FROM EventDetails WHERE  EventID= @ID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Check if data exists
                        if (dt.Rows.Count > 0)
                        {
                            // Bind DataGridView
                            dataGridView1.DataSource = dt;

                            // Calculate and update the Total label
                            decimal total = 0;
                            foreach (DataRow row in dt.Rows)
                            {
                                total += Convert.ToDecimal(row["Invoice"]); // Assuming 'Amount' column exists
                            }

                            label6.Text = $" {total:C}"; // Display total with currency formatting
                        }
                        else
                        {
                            MessageBox.Show("No data found for this invoice.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InvoiceGenerate_Load(object sender, EventArgs e)
        {

            // Step 1: Retrieve the Name from DetailsCustomer using the Email
            string customerName = GetCustomerName(eventEmail);

            // Step 2: Display values in the Labels
            label4.Text = eventEmail; 
            label2.Text = customerName; // Display customer name

            // Step 3: Load other invoice details into the grid
            LoadInvoiceData(selectedID);
        }
    }
}
