using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Edit_Form : UserControl
    {
        public static int index { get; set; }
        public static string TaskName { get; set; }
        public static string TaskDescription { get; set; }
        public static string TaskDeadline{ get; set; }


        public Edit_Form()
        {
            InitializeComponent();
        }

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            TaskNameTXT.Text = TaskName;
            TextDecriptionTXT.Text = TaskDescription;
            dateTimePicker1.Value = DateTime.Parse(TaskDeadline);
            Form1.BackButtonControl.Click += BackButtonControl_Click;
          
        }
        private void BackButtonControl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Control c = this.Parent.Controls[1];
            c.Visible = true;
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            TASK.listTasks[index].TaskName = TaskNameTXT.Text;
            TASK.listTasks[index].TaskDescription = TextDecriptionTXT.Text;
            TASK.listTasks[index].TaskDeadline = dateTimePicker1.Value.ToString();
            TASK.truncateFile();
            foreach (TASK task in TASK.listTasks)
            {
                TASK.Store_Data(task);
            }
            MessageBox.Show("Task was modified");
            this.Visible = false;
            Control c = this.Parent.Controls[1];
            c.Visible = true;
            TASK.Load_formData(c);
        }
    }
}
