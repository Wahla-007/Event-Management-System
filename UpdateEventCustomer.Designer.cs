namespace Event_Mangement_System
{
    partial class UpdateEventCustomer
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
            detail = new TextBox();
            baloon = new TextBox();
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
            linkLabel1 = new LinkLabel();
            label6 = new Label();
            id = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(244, 559);
            button1.Name = "button1";
            button1.Size = new Size(574, 58);
            button1.TabIndex = 37;
            button1.Text = "Update Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // detail
            // 
            detail.Anchor = AnchorStyles.None;
            detail.Location = new Point(431, 443);
            detail.Multiline = true;
            detail.Name = "detail";
            detail.Size = new Size(387, 97);
            detail.TabIndex = 33;
            // 
            // baloon
            // 
            baloon.Anchor = AnchorStyles.None;
            baloon.Location = new Point(431, 373);
            baloon.Name = "baloon";
            baloon.Size = new Size(387, 31);
            baloon.TabIndex = 34;
            // 
            // company
            // 
            company.Anchor = AnchorStyles.None;
            company.Location = new Point(431, 308);
            company.Name = "company";
            company.Size = new Size(387, 31);
            company.TabIndex = 35;
            // 
            // place
            // 
            place.Anchor = AnchorStyles.None;
            place.Location = new Point(431, 244);
            place.Name = "place";
            place.Size = new Size(387, 31);
            place.TabIndex = 36;
            // 
            // timee
            // 
            timee.Anchor = AnchorStyles.None;
            timee.Format = DateTimePickerFormat.Time;
            timee.Location = new Point(631, 151);
            timee.Name = "timee";
            timee.ShowUpDown = true;
            timee.Size = new Size(187, 31);
            timee.TabIndex = 31;
            // 
            // date
            // 
            date.Anchor = AnchorStyles.None;
            date.Format = DateTimePickerFormat.Short;
            date.Location = new Point(431, 151);
            date.Name = "date";
            date.Size = new Size(194, 31);
            date.TabIndex = 32;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(241, 442);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 26;
            label8.Text = "Details :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(241, 374);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 27;
            label5.Text = "Baloon Quantity:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(241, 309);
            label4.Name = "label4";
            label4.Size = new Size(187, 30);
            label4.TabIndex = 28;
            label4.Text = "Event Company :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 245);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 29;
            label3.Text = "Event place :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(244, 151);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 30;
            label1.Text = "Date / Time :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(377, 71);
            label2.Name = "label2";
            label2.Size = new Size(464, 46);
            label2.TabIndex = 25;
            label2.Text = "Update Event (CUST.) ";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Gray;
            linkLabel1.Location = new Point(244, 620);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 38;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(241, 198);
            label6.Name = "label6";
            label6.Size = new Size(112, 30);
            label6.TabIndex = 29;
            label6.Text = "Event ID :";
            // 
            // id
            // 
            id.Anchor = AnchorStyles.None;
            id.Location = new Point(431, 197);
            id.Name = "id";
            id.Size = new Size(387, 31);
            id.TabIndex = 36;
            // 
            // UpdateEventCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 652);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(detail);
            Controls.Add(baloon);
            Controls.Add(company);
            Controls.Add(id);
            Controls.Add(place);
            Controls.Add(timee);
            Controls.Add(date);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "UpdateEventCustomer";
            Text = "UpdateEventCustomer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox detail;
        private TextBox baloon;
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
        private LinkLabel linkLabel1;
        private Label label6;
        private TextBox id;
    }
}