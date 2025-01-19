namespace Event_Mangement_System
{
    partial class AdminMenu
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
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            update = new Button();
            remove = new Button();
            addevent = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 107);
            button1.Name = "button1";
            button1.Size = new Size(183, 44);
            button1.TabIndex = 1;
            button1.Text = "Event Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 35);
            label1.Name = "label1";
            label1.Size = new Size(129, 46);
            label1.TabIndex = 2;
            label1.Text = "Menu";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 178);
            button2.Name = "button2";
            button2.Size = new Size(183, 44);
            button2.TabIndex = 1;
            button2.Text = "Gallery";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(12, 253);
            button3.Name = "button3";
            button3.Size = new Size(183, 44);
            button3.TabIndex = 1;
            button3.Text = "Invoice Generate";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(12, 326);
            button4.Name = "button4";
            button4.Size = new Size(183, 44);
            button4.TabIndex = 1;
            button4.Text = "Inventory";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(12, 407);
            button5.Name = "button5";
            button5.Size = new Size(183, 44);
            button5.TabIndex = 1;
            button5.Text = "Ledger";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(201, 35);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1314, 416);
            dataGridView1.TabIndex = 3;
            // 
            // update
            // 
            update.BackColor = SystemColors.ControlDark;
            update.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(849, 467);
            update.Name = "update";
            update.Size = new Size(183, 36);
            update.TabIndex = 1;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // remove
            // 
            remove.BackColor = SystemColors.ControlDark;
            remove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(660, 467);
            remove.Name = "remove";
            remove.Size = new Size(183, 36);
            remove.TabIndex = 1;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // addevent
            // 
            addevent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addevent.Location = new Point(660, 523);
            addevent.Name = "addevent";
            addevent.Size = new Size(372, 44);
            addevent.TabIndex = 1;
            addevent.Text = "Add Event";
            addevent.UseVisualStyleBackColor = true;
            addevent.Click += addevent_Click;
            // 
            // AdminMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1523, 579);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(remove);
            Controls.Add(addevent);
            Controls.Add(update);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminMenu";
            Text = "AdminMenu";
            Load += AdminMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Button update;
        private Button remove;
        private Button addevent;
    }
}