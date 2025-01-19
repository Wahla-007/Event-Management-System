namespace Event_Mangement_System
{
    partial class Gallery
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
            label1 = new Label();
            upload = new Button();
            cat = new Button();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 26);
            label1.Name = "label1";
            label1.Size = new Size(160, 46);
            label1.TabIndex = 3;
            label1.Text = "Gallery";
            // 
            // upload
            // 
            upload.Anchor = AnchorStyles.None;
            upload.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            upload.Location = new Point(764, 542);
            upload.Name = "upload";
            upload.Size = new Size(387, 58);
            upload.TabIndex = 43;
            upload.Text = "Upload image";
            upload.UseVisualStyleBackColor = true;
            upload.Click += upload_Click;
            // 
            // cat
            // 
            cat.Anchor = AnchorStyles.None;
            cat.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cat.Location = new Point(357, 542);
            cat.Name = "cat";
            cat.Size = new Size(387, 58);
            cat.TabIndex = 44;
            cat.Text = "Add Category";
            cat.UseVisualStyleBackColor = true;
            cat.Click += cat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1117, 406);
            dataGridView1.TabIndex = 45;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(34, 542);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 46;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Gallery
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 612);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(cat);
            Controls.Add(upload);
            Controls.Add(label1);
            Name = "Gallery";
            Text = "Gallery";
            Load += Gallery_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button upload;
        private Button cat;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
    }
}