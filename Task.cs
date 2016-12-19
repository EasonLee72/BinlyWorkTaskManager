using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace BinlyWorkTaskManager
{

    [Serializable()]
    [XmlRootAttribute("Task")]
    public class Task
    {
        public string empID { get; set; }
        public string workNo { get; set; }
        public List<SubTask> subTasks { get; set; }
        public string uidB5 { get; set; }
        [XmlIgnore]
        public string savePath { get; set; }

    }

    public class SubTask
    {
        /// <summary>
        /// 子任務流水號
        /// </summary>
        public string subTaskSeriNo { get; set; }
        /// <summary>
        /// 工作說明
        /// </summary>
        public string taskDes { get; set; }
        /// <summary>
        /// 開工時間
        /// </summary>
        public DateTime startDate { get; set; }
        /// <summary>
        /// 收工時間
        /// </summary>
        public DateTime endDate { get; set; }
        /// <summary>
        /// 耗費時間
        /// </summary>
        public string costTime { get; set; }

        public SubTask() { }

        public SubTask(string no,string des, DateTime sdate)
        {
            this.subTaskSeriNo = no;
            this.taskDes = des;
            this.startDate = sdate;
        }
    }

}
