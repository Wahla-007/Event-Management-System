namespace Event_Mangement_System
{
    partial class CustomerSignIn
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pass = new TextBox();
            email = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button3 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(425, 401);
            button1.Name = "button1";
            button1.Size = new Size(184, 51);
            button1.TabIndex = 2;
            button1.Text = "Sign-In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(226, 414);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(171, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Create  new account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pass
            // 
            pass.Location = new Point(226, 324);
            pass.Name = "pass";
            pass.Size = new Size(397, 31);
            pass.TabIndex = 1;
            // 
            // email
            // 
            email.Location = new Point(226, 223);
            email.Name = "email";
            email.Size = new Size(397, 31);
            email.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(226, 283);
            label3.Name = "label3";
            label3.Size = new Size(147, 38);
            label3.TabIndex = 14;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(226, 182);
            label2.Name = "label2";
            label2.Size = new Size(108, 38);
            label2.TabIndex = 15;
            label2.Text = "E-mail:";
            // 
            // button3
            // 
            button3.Location = new Point(226, 76);
            button3.Name = "button3";
            button3.Size = new Size(184, 46);
            button3.TabIndex = 4;
            button3.Text = "Admin";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonShadow;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.Location = new Point(410, 66);
            button2.Name = "button2";
            button2.Size = new Size(213, 66);
            button2.TabIndex = 5;
            button2.Text = "Customer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CustomerSignIn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 525);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(pass);
            Controls.Add(email);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "CustomerSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerSignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private LinkLabel linkLabel1;
        private TextBox pass;
        private TextBox email;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
    }
}