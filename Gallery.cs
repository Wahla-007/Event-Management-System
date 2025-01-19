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
    public partial class Gallery : Form
    {
        String es = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public Gallery()
        {
            InitializeComponent();
        }
        private void BindGridView()
        {
            SqlConnection con = new SqlConnection(es);
            string query = "SELECT * FROM Gallery";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            dataGridView1.DataSource = data;

            // Configure image column
            if (dataGridView1.Columns["picture"] is DataGridViewImageColumn dgvImageColumn)
            {
                dgvImageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ensures the image maintains its aspect ratio
            }

            // Dynamically adjust row height based on the images
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["picture"].Value != null && row.Cells["picture"].Value is Image img)
                {
                    row.Height = img.Height; // Adjust row height based on the image height
                }
            }

            // Optional: Ensure columns fit the grid width
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }





        private void cat_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImageCategory imageCategory = new ImageCategory();
            imageCategory.Show();
        }

        private void upload_Click(object sender, EventArgs e)
        {
            this.Hide();
            Upload upload = new Upload();
            upload.Show();
        }

        private void Gallery_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex] is DataGridViewImageColumn && dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                // Retrieve the image from the clicked cell
                byte[] imageBytes = (byte[])dataGridView1.Rows[e.RowIndex].Cells["picture"].Value;
                Image img = ByteArrayToImage(imageBytes);

                // Display the image in a new form
                Form imageForm = new Form
                {
                    Text = "Image Viewer",
                    StartPosition = FormStartPosition.CenterScreen,
                    Size = new Size(600, 600)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = img,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Dock = DockStyle.Fill
                };

                imageForm.Controls.Add(pictureBox);
                imageForm.ShowDialog(); // Show the form as a modal dialog
            }
        }
        private Image ByteArrayToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AdminMenu menu = new AdminMenu();
            menu.Show();
        }
    }
}
