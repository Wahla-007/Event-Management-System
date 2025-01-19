namespace Event_Mangement_System
{
    partial class ImageCategory
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
            name = new TextBox();
            id = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(206, 288);
            name.Name = "name";
            name.Size = new Size(394, 31);
            name.TabIndex = 27;
            // 
            // id
            // 
            id.Location = new Point(206, 197);
            id.Name = "id";
            id.Size = new Size(394, 31);
            id.TabIndex = 28;
            // 
            // button1
            // 
            button1.Location = new Point(444, 412);
            button1.Name = "button1";
            button1.Size = new Size(187, 34);
            button1.TabIndex = 26;
            button1.Text = "Add Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(176, 412);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(309, 27);
            label3.Name = "label3";
            label3.Size = new Size(237, 45);
            label3.TabIndex = 22;
            label3.Text = "Add Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(203, 253);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 23;
            label4.Text = "Category Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(203, 162);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 24;
            label1.Text = "Category ID";
            // 
            // ImageCategory
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 578);
            Controls.Add(name);
            Controls.Add(id);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "ImageCategory";
            Text = "ImageCategory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox id;
        private Button button1;
        private LinkLabel linkLabel1;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}