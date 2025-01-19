using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace Event_Mangement_System
{
    public partial class Ledger : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Ledger()
        {
            InitializeComponent();
        }

        private void LoadEventCompanyData()
        {
            // Create a new connection and query
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT EventCompany FROM EventDetails"; // Fetch only the EventCompany column
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void Ledger_Load(object sender, EventArgs e)
        {
            LoadEventCompanyData();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null) // Ensure a row is selected
            {
                string selectedCompany = dataGridView1.CurrentRow.Cells["EventCompany"].Value.ToString();

                // Open the new form and pass the company name
                Account invoiceForm = new Account(selectedCompany);
                invoiceForm.Show();
                this.Hide(); // Optionally hide the current form
            }
            else
            {
                MessageBox.Show("Please select a company first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu m1= new AdminMenu();  
            m1.Show();
        }
    }
}
