namespace To_Do_List
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.home_Panel_Canvas1 = new To_Do_List.Home_Panel_Canvas();
            this.gradient_Panel1 = new To_Do_List.Gradient_Panel();
            this.Back_Button = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradient_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // home_Panel_Canvas1
            // 
            this.home_Panel_Canvas1.AutoScroll = true;
            this.home_Panel_Canvas1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.home_Panel_Canvas1.Dock = System.Windows.Forms.DockStyle.Top;
            this.home_Panel_Canvas1.Location = new System.Drawing.Point(0, 102);
            this.home_Panel_Canvas1.Name = "home_Panel_Canvas1";
            this.home_Panel_Canvas1.Size = new System.Drawing.Size(630, 642);
            this.home_Panel_Canvas1.TabIndex = 1;
            this.home_Panel_Canvas1.Load += new System.EventHandler(this.home_Panel_Canvas1_Load_1);
            // 
            // gradient_Panel1
            // 
            this.gradient_Panel1.Angle = 90F;
            this.gradient_Panel1.Controls.Add(this.Back_Button);
            this.gradient_Panel1.Controls.Add(this.pictureBox1);
            this.gradient_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradient_Panel1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(42)))), ((int)(((byte)(79)))));
            this.gradient_Panel1.Location = new System.Drawing.Point(0, 0);
            this.gradient_Panel1.Name = "gradient_Panel1";
            this.gradient_Panel1.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.gradient_Panel1.Size = new System.Drawing.Size(630, 102);
            this.gradient_Panel1.TabIndex = 0;
            this.gradient_Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gradient_Panel1_Paint);
            this.gradient_Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_Panel1_MouseDown);
            this.gradient_Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_Panel1_MouseMove);
            this.gradient_Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradient_Panel1_MouseUp);
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.Transparent;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.Location = new System.Drawing.Point(12, 25);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(51, 55);
            this.Back_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Back_Button.TabIndex = 2;
            this.Back_Button.TabStop = false;
            this.Back_Button.Visible = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(569, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(630, 750);
            this.Controls.Add(this.home_Panel_Canvas1);
            this.Controls.Add(this.gradient_Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gradient_Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Gradient_Panel gradient_Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Back_Button;
        private Home_Panel_Canvas home_Panel_Canvas1;
    }
}

