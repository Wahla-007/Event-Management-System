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

namespace Event_Mangement_System
{
   
    public partial class RemoveItem : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idd = id.Text.Trim();
            string namee = name.Text.Trim();

            // Validation: Check for empty fields
            if (string.IsNullOrEmpty(idd) || string.IsNullOrEmpty(namee))
            {
                MessageBox.Show("Please enter both Category ID and Category Name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate that ID is numeric
            if (!int.TryParse(idd, out int categoryId))
            {
                MessageBox.Show("Category ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database removal
            try
            {
                using (SqlConnection con = new SqlConnection(es))
                {
                    con.Open();

                    // SQL query to delete based on ID and Name
                    string query = "DELETE FROM ProductDetails WHERE CategoryID = @ID AND CategoryName = @Name";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add parameters to avoid SQL injection
                        cmd.Parameters.AddWithValue("@ID", categoryId);
                        cmd.Parameters.AddWithValue("@Name", namee);  // Use 'namee' here instead of 'name'

                        // Execute query and get the affected rows
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Item removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Clear input fields after deletion
                            id.Clear();
                            name.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No matching record found. Please check the Category ID and Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            Inventory i1= new Inventory();
            i1.Show();
        }
    }
}
