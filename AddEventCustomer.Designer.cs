namespace Event_Mangement_System
{
    partial class AddEventCustomer
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
            details = new TextBox();
            textBox3 = new TextBox();
            company = new TextBox();
            place = new TextBox();
            timee = new DateTimePicker();
            date = new DateTimePicker();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // details
            // 
            details.Anchor = AnchorStyles.None;
            details.Location = new Point(398, 398);
            details.Multiline = true;
            details.Name = "details";
            details.Size = new Size(387, 97);
            details.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Location = new Point(398, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(387, 31);
            textBox3.TabIndex = 21;
            // 
            // company
            // 
            company.Anchor = AnchorStyles.None;
            company.Location = new Point(398, 264);
            company.Name = "company";
            company.Size = new Size(387, 31);
            company.TabIndex = 22;
            // 
            // place
            // 
            place.Anchor = AnchorStyles.None;
            place.Location = new Point(398, 200);
            place.Name = "place";
            place.Size = new Size(387, 31);
            place.TabIndex = 23;
            // 
            // timee
            // 
            timee.Anchor = AnchorStyles.None;
            timee.Format = DateTimePickerFormat.Time;
            timee.Location = new Point(598, 143);
            timee.Name = "timee";
            timee.ShowUpDown = true;
            timee.Size = new Size(187, 31);
            timee.TabIndex = 16;
            // 
            // date
            // 
            date.Anchor = AnchorStyles.None;
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(398, 143);
            date.Name = "date";
            date.Size = new Size(194, 31);
            date.TabIndex = 17;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(208, 398);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 9;
            label8.Text = "Details :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(208, 330);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 12;
            label5.Text = "Baloon Quantity:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(208, 265);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 13;
            label4.Text = "Event Company :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(208, 201);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 14;
            label3.Text = "Event place :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 143);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 15;
            label1.Text = "Date / Time :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 69);
            label2.Name = "label2";
            label2.Size = new Size(402, 46);
            label2.TabIndex = 8;
            label2.Text = "Add Event (CUST.) ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(211, 511);
            button1.Name = "button1";
            button1.Size = new Size(574, 58);
            button1.TabIndex = 24;
            button1.Text = "Add Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(214, 585);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 25;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // AddEventCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(999, 619);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(details);
            Controls.Add(textBox3);
            Controls.Add(company);
            Controls.Add(place);
            Controls.Add(timee);
            Controls.Add(date);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "AddEventCustomer";
            Text = "AddEventCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox details;
        private TextBox textBox3;
        private TextBox company;
        private TextBox place;
        private DateTimePicker timee;
        private DateTimePicker date;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}