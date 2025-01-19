namespace Event_Mangement_System
{
    partial class Form1
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
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            email = new TextBox();
            pass = new TextBox();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(204, 128);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(204, 228);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 0;
            label2.Text = "E-mail:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(204, 329);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // name
            // 
            name.Location = new Point(204, 169);
            name.Name = "name";
            name.Size = new Size(397, 31);
            name.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(204, 269);
            email.Name = "email";
            email.Size = new Size(397, 31);
            email.TabIndex = 1;
            // 
            // pass
            // 
            pass.Location = new Point(204, 370);
            pass.Name = "pass";
            pass.Size = new Size(397, 31);
            pass.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(204, 447);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 25);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Registered";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(417, 434);
            button1.Name = "button1";
            button1.Size = new Size(184, 51);
            button1.TabIndex = 3;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(388, 32);
            button2.Name = "button2";
            button2.Size = new Size(213, 66);
            button2.TabIndex = 3;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(204, 42);
            button3.Name = "button3";
            button3.Size = new Size(184, 46);
            button3.TabIndex = 3;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 583);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox email;
        private TextBox pass;
        private LinkLabel linkLabel1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}