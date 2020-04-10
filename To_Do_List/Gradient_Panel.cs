using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace To_Do_List
{
    class Gradient_Panel:Panel
    {
        private float angle;
        private Color Lcl,Rclr;
        public float Angle
        {
            get
            {
                return angle;
            }
            set
            {
                angle = value;
                this.Invalidate();
            }
        }
        public Color LeftColor
        {
            get
            {
                return Lcl;
            }
            set
            {
                Lcl = value;
                this.Invalidate();
            }
        }
        public Color RightColor
        {
            get
            {
                return Rclr;
            }
            set
            {
                Rclr = value;
                this.Invalidate();
            }
        }
        public Gradient_Panel()
        {
            Lcl = Color.FromArgb(241, 241, 241);
            Rclr = Color.FromArgb(191, 191, 191);
            angle = 90f;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
          
            LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle
                , Rclr, Lcl, angle);
            e.Graphics.FillRectangle(lgb, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
