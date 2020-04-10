using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace To_Do_List
{
    public partial class Home_Panel_Canvas : UserControl
    {
        
        public Home_Panel_Canvas()
        {
            InitializeComponent();
        }
        
        private void Home_Panel_Canvas_Load(object sender, EventArgs e)
        {
           TASK.Load_formData(this);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Panel_Canvas_Validated(object sender, EventArgs e)
        {
            
        }

      
    }
}