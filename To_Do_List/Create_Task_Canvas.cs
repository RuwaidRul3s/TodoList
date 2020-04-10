using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //namespace that contains general io functions
using System.Runtime.Serialization;  
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Create_Task_Canvas : UserControl
    {
           
        public Create_Task_Canvas()
        {
            InitializeComponent();
        }

        private void Title_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TaskNameTXT_Enter(object sender, EventArgs e)
        {
            if (TaskNameTXT.Text =="Task Name")
            {
                TaskNameTXT.Text = "";
                TaskNameTXT.ForeColor = Color.Black;
            }
        }
         private void TextDecriptionTXT_Enter(object sender, EventArgs e)
        {
            if (TextDecriptionTXT.Text== "Task Description")
            {
                TextDecriptionTXT.Text = "";
                TextDecriptionTXT.ForeColor = Color.Black;
            }
        }

        private void TaskNameTXT_Leave(object sender, EventArgs e)
        {
            if (TaskNameTXT.Text == "")
            {
                TaskNameTXT.Text = "Task Name";
                TaskNameTXT.ForeColor = Color.Gray;
            }
        }

        private void TextDecriptionTXT_Leave(object sender, EventArgs e)
        {
            if (TextDecriptionTXT.Text == "")
            {
                TextDecriptionTXT.Text = "Task Description";
                TextDecriptionTXT.ForeColor = Color.Gray;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Task_Color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Task_Color.BackColor = colorDialog1.Color;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TASK t = new TASK();
            t.TaskName = TaskNameTXT.Text;
            t.TaskDescription = TextDecriptionTXT.Text;
            t.TaskDeadline = dateTimePicker1.Value.ToString();
            TASK.Store_Data(t);
            MessageBox.Show("Task was create successfully");
            this.Visible = false;
            Control c = this.Parent.Controls[1];
            c.Visible = true;
            TASK.Load_formData(c);
        }

        private void Title_Panel_Enter(object sender, EventArgs e)
        {
          
        }
    }

}
