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
    public partial class Inventory : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Inventory()
        {
            InitializeComponent();
        }
        private void LoadProductDetails()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "SELECT * FROM ProductDetails";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();

                    sda.Fill(dt); // Fetch the data
                    dataGridView1.DataSource = dt; // Bind data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            LoadProductDetails();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu m1 = new AdminMenu();
            m1.Show();
        }

        private void additem_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddInventoryItem i1= new AddInventoryItem();    
            i1.Show();
        }

        private void addcategory_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategory c1 = new AddCategory();
            c1.Show();
        }

        private void rremove_Click(object sender, EventArgs e)
        {
            this.Hide();
            RemoveItem i1 = new RemoveItem();
            i1.Show();

            //    if (dataGridView1.CurrentRow != null) // Ensure a row is selected
            //    {
            //        // Get the ProductID from the selected row (adjust column name if needed)
            //        int productId = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            //        // Confirm deletion
            //        DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //        if (result == DialogResult.Yes)
            //        {
            //            try
            //            {
            //                using (SqlConnection con = new SqlConnection(cs)) // Use your connection string
            //                {
            //                    string query = "DELETE FROM ProductDetails WHERE ProductID = @ProductID";
            //                    using (SqlCommand cmd = new SqlCommand(query, con))
            //                    {
            //                        // Add parameter to avoid SQL injection
            //                        cmd.Parameters.AddWithValue("@ProductID", productId);

            //                        con.Open();
            //                        int rowsAffected = cmd.ExecuteNonQuery();
            //                        con.Close();

            //                        if (rowsAffected > 0)
            //                        {
            //                            MessageBox.Show("Item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //                            // Refresh the DataGridView
            //                            LoadProductDetails();
            //                        }
            //                        else
            //                        {
            //                            MessageBox.Show("Error deleting the item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                        }
            //                    }
            //                }
            //            }
            //            catch (Exception ex)
            //            {
            //                MessageBox.Show("Error: " + ex.Message);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}}
        }
    }
}
