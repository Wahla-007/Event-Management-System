using System.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;
//using System.Data.SqlClient;

namespace Event_Mangement_System
{
    public partial class AdminMenu : Form
    {
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public AdminMenu()
        {
            InitializeComponent();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            String query = "select* from EventDetails";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            BindGridView();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEventAdmin menu = new UpdateEventAdmin();
            menu.Show();
        }

        private void addevent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEventAdmin add = new AddEventAdmin();
            add.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu();
            menu.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Check if a row is selected
            {
                // Get the Id of the selected row (assuming 'Id' is the first column in your table)
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Database deletion
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "DELETE FROM EventDetails WHERE EventId = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                // Remove row from DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

                MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ledger l1 = new Ledger();
            l1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory i2 = new Inventory();
            i2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure that the user selects a row
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Retrieve the ID and Email from the selected row
                    string selectedID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); // Column 0: ID
                    string selectedEmail = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); // Column 1: Email

                    // Open the InvoiceGenerate form and pass the selected ID and Email
                    InvoiceGenerate invoiceForm = new InvoiceGenerate(selectedID, selectedEmail);
                    invoiceForm.Show();
                }
                else
                {
                    MessageBox.Show("Please select a row first!", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gallery g = new Gallery();
            g.Show();
        }
    }
}
