namespace Event_Mangement_System
{
    partial class Upload
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
            id = new TextBox();
            label9 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            addimage = new Button();
            categ = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // id
            // 
            id.Anchor = AnchorStyles.None;
            id.Location = new Point(277, 72);
            id.Name = "id";
            id.Size = new Size(387, 31);
            id.TabIndex = 43;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(137, 71);
            label9.Name = "label9";
            label9.Size = new Size(42, 30);
            label9.TabIndex = 42;
            label9.Text = "ID:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 23);
            label2.Name = "label2";
            label2.Size = new Size(282, 46);
            label2.TabIndex = 41;
            label2.Text = "Upload Image";
            // 
            // button1
            // 
            button1.Location = new Point(277, 473);
            button1.Name = "button1";
            button1.Size = new Size(184, 51);
            button1.TabIndex = 44;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(277, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 311);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // addimage
            // 
            addimage.Location = new Point(480, 473);
            addimage.Name = "addimage";
            addimage.Size = new Size(184, 51);
            addimage.TabIndex = 46;
            addimage.Text = "Add";
            addimage.UseVisualStyleBackColor = true;
            addimage.Click += addimage_Click;
            // 
            // categ
            // 
            categ.Anchor = AnchorStyles.None;
            categ.Location = new Point(277, 109);
            categ.Name = "categ";
            categ.Size = new Size(387, 31);
            categ.TabIndex = 48;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 108);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 47;
            label1.Text = "Category:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(154, 486);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 49;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Upload
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 536);
            Controls.Add(linkLabel1);
            Controls.Add(categ);
            Controls.Add(label1);
            Controls.Add(addimage);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(id);
            Controls.Add(label9);
            Controls.Add(label2);
            Name = "Upload";
            Text = "Upload";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox id;
        private Label label9;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button addimage;
        private TextBox categ;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}