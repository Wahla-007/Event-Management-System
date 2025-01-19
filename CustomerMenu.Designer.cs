namespace Event_Mangement_System
{
    partial class CustomerMenu
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
            dataGridView1 = new DataGridView();
            remove = new Button();
            addevent = new Button();
            update = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(132, 81);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(280, 46);
            label2.TabIndex = 3;
            label2.Text = "Event Record";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 290);
            dataGridView1.TabIndex = 8;
            // 
            // remove
            // 
            remove.BackColor = SystemColors.ControlDark;
            remove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            remove.Location = new Point(595, 369);
            remove.Name = "remove";
            remove.Size = new Size(183, 36);
            remove.TabIndex = 5;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // addevent
            // 
            addevent.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addevent.Location = new Point(595, 411);
            addevent.Name = "addevent";
            addevent.Size = new Size(381, 63);
            addevent.TabIndex = 6;
            addevent.Text = "Add Event";
            addevent.UseVisualStyleBackColor = true;
            addevent.Click += addevent_Click;
            // 
            // update
            // 
            update.BackColor = SystemColors.ControlDark;
            update.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            update.Location = new Point(793, 369);
            update.Name = "update";
            update.Size = new Size(183, 36);
            update.TabIndex = 7;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            label3.Location = new Point(160, 525);
            label3.Name = "label3";
            label3.Size = new Size(741, 25);
            label3.TabIndex = 9;
            label3.Text = "Invoice and employee details will be provided within 24 hrs of the  event  registration.";
            // 
            // CustomerMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 559);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(remove);
            Controls.Add(addevent);
            Controls.Add(update);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerMenu";
            Load += CustomerMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button remove;
        private Button addevent;
        private Button update;
        private Label label3;
    }
}