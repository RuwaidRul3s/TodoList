namespace To_Do_List
{
    partial class Create_Task_Canvas
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title_Panel = new System.Windows.Forms.Panel();
            this.DeadlineDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.Task_Color = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDecriptionTXT = new System.Windows.Forms.TextBox();
            this.TaskNameTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Title_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title_Panel
            // 
            this.Title_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Title_Panel.Controls.Add(this.DeadlineDate);
            this.Title_Panel.Controls.Add(this.dateTimePicker1);
            this.Title_Panel.Controls.Add(this.button1);
            this.Title_Panel.Controls.Add(this.Task_Color);
            this.Title_Panel.Controls.Add(this.label2);
            this.Title_Panel.Controls.Add(this.TextDecriptionTXT);
            this.Title_Panel.Controls.Add(this.TaskNameTXT);
            this.Title_Panel.Controls.Add(this.label1);
            this.Title_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title_Panel.Location = new System.Drawing.Point(0, 0);
            this.Title_Panel.Name = "Title_Panel";
            this.Title_Panel.Size = new System.Drawing.Size(626, 746);
            this.Title_Panel.TabIndex = 0;
            this.Title_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Title_Panel_Paint);
            this.Title_Panel.Enter += new System.EventHandler(this.Title_Panel_Enter);
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.AutoSize = true;
            this.DeadlineDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineDate.Location = new System.Drawing.Point(17, 413);
            this.DeadlineDate.Margin = new System.Windows.Forms.Padding(30);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.Size = new System.Drawing.Size(97, 24);
            this.DeadlineDate.TabIndex = 9;
            this.DeadlineDate.Text = "Deadline :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 413);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 24);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(142, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task_Color
            // 
            this.Task_Color.BackColor = System.Drawing.Color.DarkRed;
            this.Task_Color.Location = new System.Drawing.Point(185, 342);
            this.Task_Color.Margin = new System.Windows.Forms.Padding(30);
            this.Task_Color.Name = "Task_Color";
            this.Task_Color.Size = new System.Drawing.Size(25, 24);
            this.Task_Color.TabIndex = 6;
            this.Task_Color.Click += new System.EventHandler(this.Task_Color_Click);
            this.Task_Color.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Task Label Color :";
            // 
            // TextDecriptionTXT
            // 
            this.TextDecriptionTXT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDecriptionTXT.ForeColor = System.Drawing.Color.Gray;
            this.TextDecriptionTXT.Location = new System.Drawing.Point(21, 173);
            this.TextDecriptionTXT.Margin = new System.Windows.Forms.Padding(30);
            this.TextDecriptionTXT.Multiline = true;
            this.TextDecriptionTXT.Name = "TextDecriptionTXT";
            this.TextDecriptionTXT.Size = new System.Drawing.Size(457, 131);
            this.TextDecriptionTXT.TabIndex = 2;
            this.TextDecriptionTXT.Text = "Task Description";
            this.TextDecriptionTXT.Enter += new System.EventHandler(this.TextDecriptionTXT_Enter);
            this.TextDecriptionTXT.Leave += new System.EventHandler(this.TextDecriptionTXT_Leave);
            // 
            // TaskNameTXT
            // 
            this.TaskNameTXT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTXT.ForeColor = System.Drawing.Color.Gray;
            this.TaskNameTXT.Location = new System.Drawing.Point(21, 108);
            this.TaskNameTXT.Margin = new System.Windows.Forms.Padding(30);
            this.TaskNameTXT.Name = "TaskNameTXT";
            this.TaskNameTXT.Size = new System.Drawing.Size(457, 32);
            this.TaskNameTXT.TabIndex = 1;
            this.TaskNameTXT.Text = "Task Name";
            this.TaskNameTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TaskNameTXT.Enter += new System.EventHandler(this.TaskNameTXT_Enter);
            this.TaskNameTXT.Leave += new System.EventHandler(this.TaskNameTXT_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Create_Task_Canvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title_Panel);
            this.Name = "Create_Task_Canvas";
            this.Size = new System.Drawing.Size(626, 746);
            this.Title_Panel.ResumeLayout(false);
            this.Title_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Title_Panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TaskNameTXT;
        private System.Windows.Forms.Panel Task_Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextDecriptionTXT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label DeadlineDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
