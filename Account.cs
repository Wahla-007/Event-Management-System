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
    public partial class Account : Form
    {
        private String ss;
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

        public Account(String nas)
        {
            InitializeComponent();
            ss = nas;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Ledger l1 = new Ledger();
            l1.Show();
        }

        private void LoadInvoiceDetails()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT Invoice, EventPlace, EventDate, EventTime, Details " +
                           "FROM EventDetails WHERE EventCompany = @company";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@company", ss);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    // Assuming you display the data in labels or a DataGridView
                    dataGridView1.DataSource = dt; // Bind data to DataGridView
                }
                else
                {
                    MessageBox.Show("No invoice details found for this company.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void Account_Load(object sender, EventArgs e)
        {
            LoadInvoiceDetails();

        }
    }
}
