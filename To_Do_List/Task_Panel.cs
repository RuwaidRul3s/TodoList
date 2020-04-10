using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace To_Do_List
{
    public partial class Task_Panel : UserControl
    {

        public int index = 0;
        public string TaskName
        {
            set
            {

                TaskNameTxt.Text = value;
            }
        }
        public string TaskDescription
        {
            set
            {
                Task_decriptionTXT.Text = value;
            }
        }
        public string TaskDeadLine
        {
            set
            {
                Task_DeadLineTxt.Text = value;
            }
        }

        public Task_Panel()
        {

            InitializeComponent();
        }

        private void Task_Panel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            ControlPaint.DrawBorder3D(g, this.ClientRectangle,
                Border3DStyle.Flat);
            g.Dispose();
        }



        private void Delete_Button_Click(object sender, EventArgs e)
        {
            /* get the index of the control 
             then delete it from the file = (index*sizeof(TASK))
             */

            //load tasks from the file
            TASK.truncateFile();
            TASK.listTasks.RemoveAt(index);
            if (TASK.listTasks.Count != 0)
            {
                foreach (var item in TASK.listTasks)
                {
                    TASK.Store_Data(item);
                }

            }
            else
            {
                this.Parent.Controls.Clear();
            }
            TASK.Load_formData(this.Parent);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.BackButtonControl.Visible = true;
            Edit_Form ef = new Edit_Form();
            this.Parent.Visible = false;
            Edit_Form.TaskName = TASK.listTasks[index].TaskName;
            Edit_Form.TaskDescription = TASK.listTasks[index].TaskDescription;
            Edit_Form.TaskDeadline = TASK.listTasks[index].TaskDeadline;
            Edit_Form.index = index;
            this.Parent.Parent.Controls.Add(ef);
        }

       

      
    }
}