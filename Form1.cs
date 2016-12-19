using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BinlyWorkTaskManager
{
    public partial class Form1 : Form
    {
        //workNo: 工單編碼
        //taskNo: 工作編號(子項)
        private string workingXmlSavePath = @"D:\binly\workTask\working";
        private string finishXmlSavePath = @"D:\binly\workTask\finish";
        private string xmlFileFormat = @"{0}\{1}\{2}.xml";//0:儲存路徑 1:工單號碼 2:員編


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTaskToFile(textBox_empID.Text, textBox_workNo.Text, textBox_uidB5.Text, textBox_taskDes.Text);
            ReflashWorkingList();
        }

        private void AddNewTaskToFile(string empID, string workNo, string uidB5, string taskDes)
        {
            if (string.IsNullOrEmpty(workNo))
            {
                workNo = DateTime.Now.ToShortDateString().Replace("/", "");//沒輸工單號碼,就先用日期暫代
            }
            string fileName = GetWorkingXmlFilePath(workNo, empID);



            if (File.Exists(fileName))
            {
                String xmlContent = string.Empty;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    xmlContent = sr.ReadToEnd();
                }
                Task task = XmlDeal.XmlToObj<Task>(xmlContent);
                task.subTasks.Add(new SubTask(task.subTasks.Count.ToString(), taskDes, DateTime.Now));

                xmlContent = XmlDeal.ObjToXml<Task>(task);
                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.Write(xmlContent);
                }
            }
            else
            {
                if (!Directory.Exists(new FileInfo(fileName).Directory.ToString()))
                {
                    Directory.CreateDirectory(new FileInfo(fileName).Directory.ToString());
                }

                Task task = new Task();
                task.empID = empID;
                task.workNo = workNo;
                task.uidB5 = uidB5;
                task.subTasks = new List<SubTask>();
                task.subTasks.Add(new SubTask(task.subTasks.Count.ToString(), taskDes, DateTime.Now));

                string xmlContent = XmlDeal.ObjToXml<Task>(task);

                using (StreamWriter sw = File.CreateText(fileName))
                {
                    sw.Write(xmlContent);

                }
            }
        }

        private string GetWorkingXmlFilePath(string workNo, string empID)
        {
            return string.Format(xmlFileFormat, workingXmlSavePath, workNo, empID);
        }

        private void ReflashWorkingList()
        {
            DirectoryInfo dir = new DirectoryInfo(new FileInfo(this.workingXmlSavePath).Directory.ToString());
            if (!dir.Exists)
            {
                dir.Create();
            }
            var files = dir.GetFiles("*.xml", SearchOption.AllDirectories);
            List<Task> taskList = new List<Task>();

            foreach (var f in files)
            {
                String xmlContent = string.Empty;
                using (StreamReader sr = new StreamReader(f.FullName))
                {
                    xmlContent = sr.ReadToEnd();
                }
                try
                {
                    Task task = XmlDeal.XmlToObj<Task>(xmlContent);
                    task.savePath = f.FullName;
                    taskList.Add(task);
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("檔案{0} 轉換時發生錯誤,請洽系統管理員,{1}", f.FullName,e.Message));
                }
            }


            RemoveAllWorkingList();

            foreach (Task task in taskList)
            {
                foreach (SubTask subTask in task.subTasks.Where(p=>Convert.ToDateTime( p.endDate).Equals(DateTime.MinValue)))
                {
                    DataGridViewRow row = new DataGridViewRow();

                    this.workingList_DataGridView.Rows.Add(task.empID, task.workNo, task.uidB5, subTask.taskDes, subTask.startDate.ToShortDateString() + " " + subTask.startDate.ToShortTimeString(), null, null, task.savePath, subTask.subTaskSeriNo);
                }

            }

        }







        private void RemoveAllWorkingList()
        {
            this.workingList_DataGridView.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReflashWorkingList();
        }

        private void workingListClick(object sender, DataGridViewCellEventArgs e)
        {
            string fileName, xmlContent;
            Task task = null;
            if (this.workingList_DataGridView.Rows[e.RowIndex].Cells["empID"] != null)
            {
                switch (e.ColumnIndex)
                {
                    case 5:
                        //收工鈕
                        fileName = workingList_DataGridView.Rows[e.RowIndex].Cells["xmlPath"].Value.ToString();
                        xmlContent = string.Empty;
                        using (StreamReader sr = new StreamReader(fileName))
                        {
                            xmlContent = sr.ReadToEnd();
                        }

                        task = XmlDeal.XmlToObj<Task>(xmlContent);
                        DateTime startDate = task.subTasks.Where(p => p.subTaskSeriNo.Equals(workingList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo"].Value.ToString())).Single().startDate;
                        task.subTasks.Where(p => p.subTaskSeriNo.Equals(workingList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo"].Value.ToString())).Single().endDate = DateTime.Now;
                        task.subTasks.Where(p => p.subTaskSeriNo.Equals(workingList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo"].Value.ToString())).Single().costTime =DateDiffStr(DateTime.Now ,startDate);

                        xmlContent = XmlDeal.ObjToXml<Task>(task);
                        using (StreamWriter sw = File.CreateText(fileName))
                        {
                            sw.Write(xmlContent);
                        }
                        ReflashWorkingList();
                        break;

                    case 6:
                        //儲存編輯
                        //工作說明儲存
                        fileName = workingList_DataGridView.Rows[e.RowIndex].Cells["xmlPath"].Value.ToString();
                        xmlContent = string.Empty;
                        using (StreamReader sr = new StreamReader(fileName))
                        {
                            xmlContent = sr.ReadToEnd();
                        }

                        task = XmlDeal.XmlToObj<Task>(xmlContent);
                        task.workNo = workingList_DataGridView.Rows[e.RowIndex].Cells["workNo"].Value.ToString();
                        task.uidB5 = workingList_DataGridView.Rows[e.RowIndex].Cells["uidB5"].Value.ToString();
                        task.subTasks.Where(p => p.subTaskSeriNo.Equals(workingList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo"].Value.ToString())).Single().taskDes = workingList_DataGridView.Rows[e.RowIndex].Cells["taskDes"].Value.ToString();


                        xmlContent = XmlDeal.ObjToXml<Task>(task);
                        using (StreamWriter sw = File.CreateText(fileName))
                        {
                            sw.Write(xmlContent);
                        }


                        //處理儲存路徑改變
                        string savePathNow = GetWorkingXmlFilePath(workingList_DataGridView.Rows[e.RowIndex].Cells["workNo"].Value.ToString(), workingList_DataGridView.Rows[e.RowIndex].Cells["empID"].Value.ToString());                      
                        if (!savePathNow.Equals(fileName))
                        {
                            if (! new DirectoryInfo(new FileInfo(savePathNow).Directory.ToString()).Exists)
                            {
                                new DirectoryInfo(new FileInfo(savePathNow).Directory.ToString()).Create();
                            }
                            if (File.Exists(savePathNow))
                            {
                                String xmlContent2 = string.Empty;
                                using (StreamReader sr = new StreamReader(savePathNow))
                                {
                                    xmlContent2 = sr.ReadToEnd();
                                }
                                Task task2 = XmlDeal.XmlToObj<Task>(xmlContent2);
                                SubTask subtask2 = new SubTask(task2.subTasks.Count.ToString(), workingList_DataGridView.Rows[e.RowIndex].Cells["taskDes"].Value.ToString(), Convert.ToDateTime(workingList_DataGridView.Rows[e.RowIndex].Cells["startDate"].Value));
                                
                                task2.subTasks.Add(subtask2);

                                xmlContent2 = XmlDeal.ObjToXml<Task>(task2);
                                using (StreamWriter sw = File.CreateText(savePathNow))
                                {
                                    sw.Write(xmlContent2);
                                }
                            }
                            else
                            {
                                File.Copy(fileName, savePathNow);
                                File.Delete(fileName);
                            }
                        }

                        ReflashWorkingList();
                        break;
                }

            }
        }

        private string DateDiffStr(DateTime date1, DateTime date2)
        {
            string str = null;
            TimeSpan ts1 = new TimeSpan(date1.Ticks);
            TimeSpan ts2 = new TimeSpan(date2.Ticks);
            TimeSpan ts = ts1.Subtract(ts2).Duration();
            string day = ts.Days>0 ? ts.Days+"天":"";
            string hour = ts.TotalHours>0?ts.Hours+"小時":"";
            string mins = ts.TotalMinutes>0?ts.Minutes+"分鐘":"";
            string sec = ts.TotalSeconds>0?ts.Seconds+"秒":"";
            str = day + hour + mins + sec;
            return str;
        }

        void workedList_DataGridView_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            string fileName, xmlContent;
            Task task = null;
            if (this.workedList_DataGridView.Rows[e.RowIndex].Cells["empID_"] != null)
            {
                switch (e.ColumnIndex)
                {
                    case 7:
                        //儲存編輯
                        //工作說明儲存
                        try
                        {
                            fileName = workedList_DataGridView.Rows[e.RowIndex].Cells["xmlPath_"].Value.ToString();
                            xmlContent = string.Empty;
                            using (StreamReader sr = new StreamReader(fileName))
                            {
                                xmlContent = sr.ReadToEnd();
                            }

                            task = XmlDeal.XmlToObj<Task>(xmlContent);
                            task.workNo = workedList_DataGridView.Rows[e.RowIndex].Cells["workNo_"].Value.ToString();
                            task.empID = workedList_DataGridView.Rows[e.RowIndex].Cells["empID_"].Value.ToString();
                            task.uidB5 = workedList_DataGridView.Rows[e.RowIndex].Cells["uidB5_"].Value.ToString();
                            task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().startDate = Convert.ToDateTime(workedList_DataGridView.Rows[e.RowIndex].Cells["startDate_"].Value.ToString());
                            task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().endDate = Convert.ToDateTime(workedList_DataGridView.Rows[e.RowIndex].Cells["endDate_"].Value);
                            task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().taskDes = workedList_DataGridView.Rows[e.RowIndex].Cells["taskDes_"].Value.ToString();

                            DateTime startDate = task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().startDate;
                            DateTime endDate = task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().endDate;


                            task.subTasks.Where(p => p.subTaskSeriNo.Equals(workedList_DataGridView.Rows[e.RowIndex].Cells["subTaskSeriNo_"].Value.ToString())).Single().costTime = DateDiffStr(endDate ,startDate);

                            xmlContent = XmlDeal.ObjToXml<Task>(task);
                            using (StreamWriter sw = File.CreateText(fileName))
                            {
                                sw.Write(xmlContent);
                            }


                            //處理儲存路徑改變
                            string savePathNow = GetWorkingXmlFilePath(workedList_DataGridView.Rows[e.RowIndex].Cells["workNo_"].Value.ToString(), workedList_DataGridView.Rows[e.RowIndex].Cells["empID_"].Value.ToString());
                            if (!savePathNow.Equals(fileName))
                            {
                                if (!new DirectoryInfo(new FileInfo(savePathNow).Directory.ToString()).Exists)
                                {
                                    new DirectoryInfo(new FileInfo(savePathNow).Directory.ToString()).Create();
                                }
                                if (File.Exists(savePathNow))
                                {
                                    String xmlContent2 = string.Empty;
                                    using (StreamReader sr = new StreamReader(savePathNow))
                                    {
                                        xmlContent2 = sr.ReadToEnd();
                                    }
                                    Task task2 = XmlDeal.XmlToObj<Task>(xmlContent2);
                                    SubTask subtask2 = new SubTask(task2.subTasks.Count.ToString(), workedList_DataGridView.Rows[e.RowIndex].Cells["taskDes_"].Value.ToString(), Convert.ToDateTime(workedList_DataGridView.Rows[e.RowIndex].Cells["startDate_"].Value));

                                    task2.subTasks.Add(subtask2);

                                    xmlContent2 = XmlDeal.ObjToXml<Task>(task2);
                                    using (StreamWriter sw = File.CreateText(savePathNow))
                                    {
                                        sw.Write(xmlContent2);
                                    }
                                }
                                else
                                {
                                    File.Copy(fileName, savePathNow);
                                    File.Delete(fileName);
                                }
                            }

                            
                        }
                        catch (Exception e2)
                        {
                            MessageBox.Show("儲存失敗! 訊息:"+e2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ReflashWorkedList();
                        break;
                }

            }
        }

        void workingList_DataGridView_CellValueChanged(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
                ((DataGridView)(sender)).Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            ReflashWorkedList();
        }

        private void ReflashWorkedList()
        {
            DirectoryInfo dir = new DirectoryInfo(new FileInfo(this.workingXmlSavePath).Directory.ToString());
            if (!dir.Exists)
            {
                dir.Create();
            }
            var files = dir.GetFiles("*.xml", SearchOption.AllDirectories);
            List<Task> taskList = new List<Task>();

            foreach (var f in files)
            {
                String xmlContent = string.Empty;
                using (StreamReader sr = new StreamReader(f.FullName))
                {
                    xmlContent = sr.ReadToEnd();
                }
                try
                {
                    Task task = XmlDeal.XmlToObj<Task>(xmlContent);
                    task.savePath = f.FullName;
                    taskList.Add(task);
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("檔案{0} 轉換時發生錯誤,請洽系統管理員,{1}", f.FullName, e.Message));
                }
            }


            this.workedList_DataGridView.Rows.Clear();

            foreach (Task task in taskList)
            {
                foreach (SubTask subTask in task.subTasks.Where(p => !Convert.ToDateTime(p.endDate).Equals(DateTime.MinValue)))
                {
                    DataGridViewRow row = new DataGridViewRow();

                    this.workedList_DataGridView.Rows.Add(task.empID, task.workNo, task.uidB5, subTask.taskDes, subTask.startDate.ToShortDateString() + " " + subTask.startDate.ToShortTimeString(), subTask.endDate.ToShortTimeString(),(subTask.costTime), null, task.savePath, subTask.subTaskSeriNo);
                }

            }
        }

        private void workingList_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
