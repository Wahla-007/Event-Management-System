namespace Event_Mangement_System
{
    partial class AddInventoryItem
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
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            specification = new TextBox();
            quantity = new TextBox();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(175, 243);
            name.Name = "name";
            name.Size = new Size(394, 31);
            name.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(527, 495);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 8;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(122, 500);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(48, 25);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Back";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 54);
            label3.Name = "label3";
            label3.Size = new Size(182, 45);
            label3.TabIndex = 4;
            label3.Text = "Add Items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(172, 208);
            label4.Name = "label4";
            label4.Size = new Size(199, 32);
            label4.TabIndex = 5;
            label4.Text = "Category Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 307);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 6;
            label2.Text = "Specification";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(172, 398);
            label5.Name = "label5";
            label5.Size = new Size(120, 32);
            label5.TabIndex = 5;
            label5.Text = "Quantity:";
            // 
            // specification
            // 
            specification.Location = new Point(175, 342);
            specification.Name = "specification";
            specification.Size = new Size(394, 31);
            specification.TabIndex = 10;
            // 
            // quantity
            // 
            quantity.Location = new Point(175, 433);
            quantity.Name = "quantity";
            quantity.Size = new Size(394, 31);
            quantity.TabIndex = 9;
            // 
            // AddInventoryItem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 587);
            Controls.Add(quantity);
            Controls.Add(specification);
            Controls.Add(name);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Name = "AddInventoryItem";
            Text = "AddInventoryItem";
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
        private Label label2;
        private Label label5;
        private TextBox specification;
        private TextBox quantity;
    }
}