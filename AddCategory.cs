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
    public partial class AddCategory : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AddCategory()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string categoryId = id.Text.Trim();
            string categoryName = name.Text.Trim();

            // Check if fields are empty
            if (string.IsNullOrEmpty(categoryId) || string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database logic
            try
            {
                using (SqlConnection con = new SqlConnection(es))
                {
                    con.Open();
                    string query = "INSERT INTO ProductInfo (CategoryID, CategoryName) VALUES (@id, @name)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", categoryId);
                        cmd.Parameters.AddWithValue("@name", categoryName);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Category Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            id.Clear();
                            name.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Inventory ee = new Inventory();
            ee.Show();
        }
    }
}
