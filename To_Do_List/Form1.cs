using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        bool move = false;
        private Point StartPoint;
            private Point LastPoint;
        public static PictureBox BackButtonControl;
        private Create_Task_Canvas CreateTask_Canvas = new Create_Task_Canvas();
        private StringFormat sf = new StringFormat();
        public Form1()
        {
            CreateTask_Canvas.Location = new Point(0, 108);
            CreateTask_Canvas.Visible = false;
            this.Controls.Add(CreateTask_Canvas);
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            
            InitializeComponent();
        }

        private void gradient_Panel1_Paint(object sender, PaintEventArgs e)
        {
            //Create Graphics object
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            //Text Color
            SolidBrush TextColor = new SolidBrush(Color.White);
            //Create Font
            FontFamily RobotoFamily = new FontFamily("Roboto");
            Font RobotoFont = new Font(RobotoFamily, 16, FontStyle.Regular
                ,GraphicsUnit.Point);
            g.DrawString("To-Do List", RobotoFont, TextColor,gradient_Panel1.ClientRectangle,
                sf);
            //Dispose objects
            TextColor.Dispose();
            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Back_Button.Visible = true;
            CreateTask_Canvas.Visible = true;
            
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
              
            Back_Button.Visible = false;
            CreateTask_Canvas.Visible = false;

            TASK.Load_formData(Control.FromHandle(home_Panel_Canvas1.Handle));
        }

        private void home_Panel_Canvas1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void home_Panel_Canvas1_Load_1(object sender, EventArgs e)
        {
            BackButtonControl = Back_Button;
        }

        private void gradient_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(move)
            {
                LastPoint = new Point(e.X-StartPoint.X, e.Y-StartPoint.Y);
                Point temp = PointToScreen(LastPoint);
                this.Left = temp.X;
                this.Top = temp.Y;
            }
        }

        private void gradient_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void gradient_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void gradient_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            StartPoint = new Point(e.X, e.Y);
        }
    }
}
