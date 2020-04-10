namespace To_Do_List
{
    partial class Task_Panel
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
            this.Delete_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TaskNameTxt = new System.Windows.Forms.Label();
            this.Task_DeadLineTxt = new System.Windows.Forms.Label();
            this.Task_decriptionTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Delete_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Button.Font = new System.Drawing.Font("Roboto Cn", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.White;
            this.Delete_Button.Location = new System.Drawing.Point(313, 25);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(128, 43);
            this.Delete_Button.TabIndex = 1;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(42)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Cn", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(456, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TaskNameTxt
            // 
            this.TaskNameTxt.AutoSize = true;
            this.TaskNameTxt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTxt.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TaskNameTxt.Location = new System.Drawing.Point(18, 25);
            this.TaskNameTxt.Name = "TaskNameTxt";
            this.TaskNameTxt.Size = new System.Drawing.Size(96, 24);
            this.TaskNameTxt.TabIndex = 3;
            this.TaskNameTxt.Text = "Task Name";
            // 
            // Task_DeadLineTxt
            // 
            this.Task_DeadLineTxt.AutoSize = true;
            this.Task_DeadLineTxt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_DeadLineTxt.ForeColor = System.Drawing.Color.Green;
            this.Task_DeadLineTxt.Location = new System.Drawing.Point(18, 116);
            this.Task_DeadLineTxt.Name = "Task_DeadLineTxt";
            this.Task_DeadLineTxt.Size = new System.Drawing.Size(157, 24);
            this.Task_DeadLineTxt.TabIndex = 4;
            this.Task_DeadLineTxt.Text = "Deadline 4/9/2020";
            // 
            // Task_decriptionTXT
            // 
            this.Task_decriptionTXT.AutoSize = true;
            this.Task_decriptionTXT.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_decriptionTXT.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Task_decriptionTXT.Location = new System.Drawing.Point(18, 69);
            this.Task_decriptionTXT.Name = "Task_decriptionTXT";
            this.Task_decriptionTXT.Size = new System.Drawing.Size(96, 24);
            this.Task_decriptionTXT.TabIndex = 5;
            this.Task_decriptionTXT.Text = "Task Name";
            // 
            // Task_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.Controls.Add(this.Task_decriptionTXT);
            this.Controls.Add(this.Task_DeadLineTxt);
            this.Controls.Add(this.TaskNameTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete_Button);
            this.Name = "Task_Panel";
            this.Size = new System.Drawing.Size(599, 150);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Task_Panel_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TaskNameTxt;
        private System.Windows.Forms.Label Task_DeadLineTxt;
        private System.Windows.Forms.Label Task_decriptionTXT;
    }
}
