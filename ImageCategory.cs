using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Mangement_System
{
    public partial class ImageCategory : Form
    {
        public ImageCategory()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Gallery gallery = new Gallery();
            gallery.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Category Added Successfully.");
            id.Clear();
            name.Clear();   

        }
    }
}
