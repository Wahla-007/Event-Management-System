using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Event_Mangement_System
{
    public partial class AddInventoryItem : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AddInventoryItem()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Inventory i1 = new Inventory();
            i1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string idd = id.Text.Trim();
            string namee = name.Text.Trim();
            string specifications = specification.Text.Trim();
            string quantitys = quantity.Text.Trim();

            if ( string.IsNullOrEmpty(namee) ||
                string.IsNullOrEmpty(specifications) || string.IsNullOrEmpty(quantitys))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //if (!int.TryParse(idd, out int categoryId))
            //{
            //    MessageBox.Show("Category ID must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (!int.TryParse(quantitys, out int parsedQuantity) || parsedQuantity <= 0)
            {
                MessageBox.Show("Quantity must be a positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(es))
                {
                    con.Open();
                    string query = "INSERT INTO ProductDetails (CategoryName, Specification, Quantity) " +
                                   "VALUES ( @CategoryName, @Specification, @Quantity)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        //cmd.Parameters.AddWithValue("@CategoryID", categoryId);
                        cmd.Parameters.AddWithValue("@CategoryName", namee);
                        cmd.Parameters.AddWithValue("@Specification", specifications);
                        cmd.Parameters.AddWithValue("@Quantity", parsedQuantity);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           // id.Clear();
                            name.Clear();
                            specification.Clear();
                            quantity.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
