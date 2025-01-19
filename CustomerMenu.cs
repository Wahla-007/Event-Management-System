using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace Event_Mangement_System
{

    public partial class CustomerMenu : Form
    {
        private string userEmail;
        String cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public CustomerMenu(String email)
        {
            InitializeComponent();
            userEmail = email;

        }
        public CustomerMenu()
        {
            InitializeComponent();
            

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM EventDetails WHERE Email = @Email"; // Use parameterized query
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.Parameters.AddWithValue("@Email", userEmail);  // Add parameter value

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }
        private void CustomerMenu_Load(object sender, EventArgs e)
        {
            BindGridView();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void addevent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEventCustomer ev = new AddEventCustomer(userEmail);
            ev.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            this.Hide();
           UpdateEventCustomer ev = new UpdateEventCustomer(userEmail);
            ev.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Check if a row is selected
            {
                // Get the Id of the selected row (assuming 'EventId' is the first column in your table)
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                // Database deletion
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "DELETE FROM EventDetails WHERE EventId = @EventId"; // Correct parameter name
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EventId", id); // Correct parameter name

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Row deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }

                // Remove row from DataGridView
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
