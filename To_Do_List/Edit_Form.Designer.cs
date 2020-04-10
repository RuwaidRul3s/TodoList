namespace To_Do_List
{
    partial class Edit_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.DeadlineDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Task_Color = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TextDecriptionTXT = new System.Windows.Forms.TextBox();
            this.TaskNameTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(17, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Edit Task";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DeadlineDate
            // 
            this.DeadlineDate.AutoSize = true;
            this.DeadlineDate.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeadlineDate.Location = new System.Drawing.Point(19, 503);
            this.DeadlineDate.Margin = new System.Windows.Forms.Padding(30);
            this.DeadlineDate.Name = "DeadlineDate";
            this.DeadlineDate.Size = new System.Drawing.Size(97, 24);
            this.DeadlineDate.TabIndex = 16;
            this.DeadlineDate.Text = "Deadline :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 503);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 24);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Edit_button
            // 
            this.Edit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Edit_button.FlatAppearance.BorderSize = 2;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Edit_button.Location = new System.Drawing.Point(144, 560);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(218, 59);
            this.Edit_button.TabIndex = 14;
            this.Edit_button.Text = "Edit Task";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Task_Color
            // 
            this.Task_Color.BackColor = System.Drawing.Color.DarkRed;
            this.Task_Color.Location = new System.Drawing.Point(187, 432);
            this.Task_Color.Margin = new System.Windows.Forms.Padding(30);
            this.Task_Color.Name = "Task_Color";
            this.Task_Color.Size = new System.Drawing.Size(25, 24);
            this.Task_Color.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 432);
            this.label2.Margin = new System.Windows.Forms.Padding(30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Task Label Color :";
            // 
            // TextDecriptionTXT
            // 
            this.TextDecriptionTXT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDecriptionTXT.ForeColor = System.Drawing.Color.Gray;
            this.TextDecriptionTXT.Location = new System.Drawing.Point(23, 263);
            this.TextDecriptionTXT.Margin = new System.Windows.Forms.Padding(30);
            this.TextDecriptionTXT.Multiline = true;
            this.TextDecriptionTXT.Name = "TextDecriptionTXT";
            this.TextDecriptionTXT.Size = new System.Drawing.Size(457, 131);
            this.TextDecriptionTXT.TabIndex = 11;
            this.TextDecriptionTXT.Text = "Task Description";
            // 
            // TaskNameTXT
            // 
            this.TaskNameTXT.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTXT.ForeColor = System.Drawing.Color.Gray;
            this.TaskNameTXT.Location = new System.Drawing.Point(23, 198);
            this.TaskNameTXT.Margin = new System.Windows.Forms.Padding(30);
            this.TaskNameTXT.Name = "TaskNameTXT";
            this.TaskNameTXT.Size = new System.Drawing.Size(457, 32);
            this.TaskNameTXT.TabIndex = 10;
            this.TaskNameTXT.Text = "Task Name";
            // 
            // Edit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.DeadlineDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Task_Color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextDecriptionTXT);
            this.Controls.Add(this.TaskNameTXT);
            this.Controls.Add(this.label1);
            this.Name = "Edit_Form";
            this.Size = new System.Drawing.Size(626, 746);
            this.Load += new System.EventHandler(this.Edit_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DeadlineDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Panel Task_Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextDecriptionTXT;
        private System.Windows.Forms.TextBox TaskNameTXT;
    }
}
