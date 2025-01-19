namespace Event_Mangement_System
{
    partial class AddEventAdmin
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            date = new DateTimePicker();
            Timee = new DateTimePicker();
            place = new TextBox();
            company = new TextBox();
            baloon = new TextBox();
            employee = new TextBox();
            invoice = new TextBox();
            detail = new TextBox();
            button1 = new Button();
            email = new TextBox();
            label10 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 29);
            label2.Name = "label2";
            label2.Size = new Size(428, 46);
            label2.TabIndex = 4;
            label2.Text = "Add Event (ADMIN) ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 106);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 5;
            label1.Text = "Date / Time :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(234, 158);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 5;
            label3.Text = "Event place :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(235, 254);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 5;
            label4.Text = "Event Company :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(235, 304);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 5;
            label5.Text = "Baloon Quantity:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(235, 358);
            label6.Name = "label6";
            label6.Size = new Size(136, 30);
            label6.TabIndex = 5;
            label6.Text = "Employees :";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(235, 409);
            label7.Name = "label7";
            label7.Size = new Size(99, 30);
            label7.TabIndex = 5;
            label7.Text = "Invoice :";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(235, 462);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 5;
            label8.Text = "Details :";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.None;
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(425, 106);
            date.Name = "date";
            date.Size = new Size(203, 31);
            date.TabIndex = 6;
            // 
            // Timee
            // 
            Timee.Anchor = AnchorStyles.None;
            Timee.Format = DateTimePickerFormat.Time;
            Timee.Location = new Point(634, 106);
            Timee.Name = "Timee";
            Timee.ShowUpDown = true;
            Timee.Size = new Size(164, 31);
            Timee.TabIndex = 6;
            // 
            // place
            // 
            place.Anchor = AnchorStyles.None;
            place.Location = new Point(424, 157);
            place.Name = "place";
            place.Size = new Size(387, 31);
            place.TabIndex = 7;
            // 
            // company
            // 
            company.Anchor = AnchorStyles.None;
            company.Location = new Point(425, 253);
            company.Name = "company";
            company.Size = new Size(387, 31);
            company.TabIndex = 7;
            // 
            // baloon
            // 
            baloon.Anchor = AnchorStyles.None;
            baloon.Location = new Point(425, 303);
            baloon.Name = "baloon";
            baloon.Size = new Size(387, 31);
            baloon.TabIndex = 7;
            // 
            // employee
            // 
            employee.Anchor = AnchorStyles.None;
            employee.Location = new Point(425, 357);
            employee.Name = "employee";
            employee.Size = new Size(387, 31);
            employee.TabIndex = 7;
            // 
            // invoice
            // 
            invoice.Anchor = AnchorStyles.None;
            invoice.Location = new Point(425, 408);
            invoice.Name = "invoice";
            invoice.Size = new Size(387, 31);
            invoice.TabIndex = 7;
            // 
            // detail
            // 
            detail.Anchor = AnchorStyles.None;
            detail.Location = new Point(425, 463);
            detail.Multiline = true;
            detail.Name = "detail";
            detail.Size = new Size(387, 42);
            detail.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(237, 531);
            button1.Name = "button1";
            button1.Size = new Size(574, 58);
            button1.TabIndex = 25;
            button1.Text = "Add Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.Location = new Point(424, 205);
            email.Name = "email";
            email.Size = new Size(387, 31);
            email.TabIndex = 27;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(237, 204);
            label10.Name = "label10";
            label10.Size = new Size(90, 30);
            label10.TabIndex = 28;
            label10.Text = "E-mail :";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(237, 594);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 29;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AddEventAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 628);
            Controls.Add(linkLabel1);
            Controls.Add(label10);
            Controls.Add(email);
            Controls.Add(button1);
            Controls.Add(detail);
            Controls.Add(invoice);
            Controls.Add(employee);
            Controls.Add(baloon);
            Controls.Add(company);
            Controls.Add(place);
            Controls.Add(Timee);
            Controls.Add(date);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddEventAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEventAdmin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker date;
        private DateTimePicker Timee;
        private TextBox place;
        private TextBox company;
        private TextBox baloon;
        private TextBox employee;
        private TextBox invoice;
        private TextBox detail;
        private Button button1;
        private TextBox email;
        private Label label10;
        private LinkLabel linkLabel1;
    }
}