namespace Event_Mangement_System
{
    partial class Inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            addcategory = new Button();
            additem = new Button();
            rremove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(660, 339);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 30);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(334, 503);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // addcategory
            // 
            addcategory.Location = new Point(273, 428);
            addcategory.Name = "addcategory";
            addcategory.Size = new Size(190, 34);
            addcategory.TabIndex = 3;
            addcategory.Text = "Add Category";
            addcategory.UseVisualStyleBackColor = true;
            addcategory.Click += addcategory_Click;
            // 
            // additem
            // 
            additem.Location = new Point(469, 428);
            additem.Name = "additem";
            additem.Size = new Size(190, 34);
            additem.TabIndex = 3;
            additem.Text = "Add Item";
            additem.UseVisualStyleBackColor = true;
            additem.Click += additem_Click;
            // 
            // rremove
            // 
            rremove.Location = new Point(77, 428);
            rremove.Name = "rremove";
            rremove.Size = new Size(190, 34);
            rremove.TabIndex = 3;
            rremove.Text = "Remove Item";
            rremove.UseVisualStyleBackColor = true;
            rremove.Click += rremove_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 564);
            Controls.Add(rremove);
            Controls.Add(additem);
            Controls.Add(addcategory);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button addcategory;
        private Button additem;
        private Button rremove;
    }
}