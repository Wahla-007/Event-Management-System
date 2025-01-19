namespace Event_Mangement_System
{
    partial class AdminSignup
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
            components = new System.ComponentModel.Container();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pass = new TextBox();
            email = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            key = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(415, 22);
            button3.Name = "button3";
            button3.Size = new Size(184, 46);
            button3.TabIndex = 1;
            button3.Text = "Customer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(202, 12);
            button2.Name = "button2";
            button2.Size = new Size(213, 66);
            button2.TabIndex = 0;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(415, 522);
            button1.Name = "button1";
            button1.Size = new Size(184, 51);
            button1.TabIndex = 6;
            button1.Text = "Sign-Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(202, 535);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(160, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Registered";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pass
            // 
            pass.Location = new Point(202, 350);
            pass.Name = "pass";
            pass.Size = new Size(397, 31);
            pass.TabIndex = 4;
            // 
            // email
            // 
            email.Location = new Point(202, 249);
            email.Name = "email";
            email.Size = new Size(397, 31);
            email.TabIndex = 3;
            email.Leave += email_Leave;
            // 
            // name
            // 
            name.Location = new Point(202, 149);
            name.Name = "name";
            name.Size = new Size(397, 31);
            name.TabIndex = 2;
            name.Leave += name_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(202, 309);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(202, 208);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 5;
            label2.Text = "E-mail:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 108);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 6;
            label1.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(202, 415);
            label4.Name = "label4";
            label4.Size = new Size(167, 38);
            label4.TabIndex = 4;
            label4.Text = "Admin key:";
            // 
            // key
            // 
            key.Location = new Point(202, 456);
            key.Name = "key";
            key.Size = new Size(397, 31);
            key.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // AdminSignup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 639);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(key);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(label4);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminSignup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminSignup";
            Load += AdminSignup_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox pass;
        private TextBox email;
        private TextBox name;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox key;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
    }
}