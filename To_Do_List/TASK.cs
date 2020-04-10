using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
namespace To_Do_List
{

    public class TASK
    {
       
        public static string Get_FileName()
        {
            string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string filename = Path.Combine(AppData, "TaskApplication.dat");
            return filename;
        }
        public static List<TASK> listTasks = new List<TASK>();
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDeadline { get; set; }
        public TASK()
        {
            TaskName = "Task Name";
            TaskDescription = "Task Description";
            TaskDeadline = DateTime.Now.ToString();
        }
        public static void Store_Data(TASK task)
        {
            try
            {

                Stream stream = new FileStream(Get_FileName(), FileMode.Append,
                    FileAccess.Write);
                using (BinaryWriter bw = new BinaryWriter(stream))
                {

                    bw.Write(task.TaskName);
                    bw.Write(task.TaskDescription);
                    bw.Write(task.TaskDeadline);
                }
                stream.Close();
            }
            catch (FileNotFoundException)
            {
                File.Create(Get_FileName());
            }
        }
        public static void Read_Data(string filename)
        {

            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);
            using (BinaryReader br = new BinaryReader(stream))
            {
                while (stream.Position < stream.Length)
                {
                    TASK temp = new TASK();
                    temp.TaskName = br.ReadString();
                    temp.TaskDescription = br.ReadString();
                    temp.TaskDeadline = br.ReadString();
                    listTasks.Add(temp);
                }
            }
            stream.Close();


        }
        public static void truncateFile()
        {
            FileStream oStream = new FileStream(Get_FileName(), FileMode.Open, FileAccess.ReadWrite);
            oStream.SetLength(0);
            oStream.Close();
        }
        public static void Load_formData(Control parent)
        {
            // clear the panel controls
            //clear list and controls from the form
            if(listTasks.Count!=0&&parent.Controls.Count!=0)
            {
                
                parent.Controls.Clear();
                listTasks.Clear();
            }
            //Read data from the file
            Read_Data(Get_FileName());
            // populate the forom controls
            int ControlIndex = -1;
            foreach (TASK item in listTasks)
            {
                Task_Panel temp = new Task_Panel();
                temp.TaskName = item.TaskName;
                temp.TaskDescription = item.TaskDescription;
                temp.TaskDeadLine = item.TaskDeadline;
                temp.index = ++ControlIndex;
                temp.Location = new Point(1, 150 * parent.Controls.Count);
                parent.Controls.Add(temp);
            }
        }
    }
}
