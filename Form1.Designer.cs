namespace BinlyWorkTaskManager
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBox_empID = new System.Windows.Forms.TextBox();
            this.textBox_workNo = new System.Windows.Forms.TextBox();
            this.textBox_uidB5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_taskDes = new System.Windows.Forms.TextBox();
            this.workingList_DataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.workedList_DataGridView = new System.Windows.Forms.DataGridView();
            this.empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidB5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopWork = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveWorking = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xmlPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTaskSeriNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empID_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workNo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uidB5_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskDes_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDate_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costTime_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xmlPath_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTaskSeriNo_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingList_DataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workedList_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_empID
            // 
            this.textBox_empID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_empID.Location = new System.Drawing.Point(10, 29);
            this.textBox_empID.Name = "textBox_empID";
            this.textBox_empID.Size = new System.Drawing.Size(70, 22);
            this.textBox_empID.TabIndex = 0;
            // 
            // textBox_workNo
            // 
            this.textBox_workNo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_workNo.Location = new System.Drawing.Point(93, 29);
            this.textBox_workNo.Name = "textBox_workNo";
            this.textBox_workNo.Size = new System.Drawing.Size(70, 22);
            this.textBox_workNo.TabIndex = 1;
            // 
            // textBox_uidB5
            // 
            this.textBox_uidB5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox_uidB5.Location = new System.Drawing.Point(178, 29);
            this.textBox_uidB5.Name = "textBox_uidB5";
            this.textBox_uidB5.Size = new System.Drawing.Size(71, 22);
            this.textBox_uidB5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "員編";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "工單號碼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "車號後五碼";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 493);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox_taskDes);
            this.tabPage1.Controls.Add(this.workingList_DataGridView);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox_empID);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox_workNo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_uidB5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "reflash";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "工作中列表";
            // 
            // textBox_taskDes
            // 
            this.textBox_taskDes.Location = new System.Drawing.Point(12, 81);
            this.textBox_taskDes.Name = "textBox_taskDes";
            this.textBox_taskDes.Size = new System.Drawing.Size(341, 22);
            this.textBox_taskDes.TabIndex = 6;
            // 
            // workingList_DataGridView
            // 
            this.workingList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workingList_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID,
            this.workNo,
            this.uidB5,
            this.taskDes,
            this.startDate,
            this.stopWork,
            this.saveWorking,
            this.xmlPath,
            this.subTaskSeriNo});
            this.workingList_DataGridView.Location = new System.Drawing.Point(12, 148);
            this.workingList_DataGridView.Name = "workingList_DataGridView";
            this.workingList_DataGridView.RowTemplate.Height = 24;
            this.workingList_DataGridView.Size = new System.Drawing.Size(943, 308);
            this.workingList_DataGridView.TabIndex = 5;
            this.workingList_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingListClick);
            this.workingList_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingList_DataGridView_CellContentClick);
            this.workingList_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingList_DataGridView_CellValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "開工";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "工作說明";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.workedList_DataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(962, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "已完工列表";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(81, 49);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // workedList_DataGridView
            // 
            this.workedList_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workedList_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empID_,
            this.workNo_,
            this.uidB5_,
            this.taskDes_,
            this.startDate_,
            this.endDate_,
            this.costTime_,
            this.dataGridViewButtonColumn2,
            this.xmlPath_,
            this.subTaskSeriNo_});
            this.workedList_DataGridView.Location = new System.Drawing.Point(10, 79);
            this.workedList_DataGridView.Name = "workedList_DataGridView";
            this.workedList_DataGridView.RowTemplate.Height = 24;
            this.workedList_DataGridView.Size = new System.Drawing.Size(945, 377);
            this.workedList_DataGridView.TabIndex = 6;
            this.workedList_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.workedList_DataGridView_CellClick);
            this.workedList_DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.workingList_DataGridView_CellValueChanged);
            // 
            // empID
            // 
            this.empID.HeaderText = "員編";
            this.empID.Name = "empID";
            this.empID.ReadOnly = true;
            // 
            // workNo
            // 
            this.workNo.HeaderText = "工單號碼";
            this.workNo.Name = "workNo";
            // 
            // uidB5
            // 
            this.uidB5.HeaderText = "車號後五碼";
            this.uidB5.Name = "uidB5";
            // 
            // taskDes
            // 
            this.taskDes.HeaderText = "工作說明";
            this.taskDes.Name = "taskDes";
            this.taskDes.Width = 150;
            // 
            // startDate
            // 
            this.startDate.HeaderText = "開工時間";
            this.startDate.Name = "startDate";
            this.startDate.ReadOnly = true;
            this.startDate.Width = 130;
            // 
            // stopWork
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.NullValue = "收工";
            this.stopWork.DefaultCellStyle = dataGridViewCellStyle4;
            this.stopWork.HeaderText = "收工時間";
            this.stopWork.Name = "stopWork";
            this.stopWork.Text = "";
            this.stopWork.Width = 130;
            // 
            // saveWorking
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.NullValue = "儲存編輯";
            this.saveWorking.DefaultCellStyle = dataGridViewCellStyle5;
            this.saveWorking.HeaderText = "";
            this.saveWorking.Name = "saveWorking";
            this.saveWorking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.saveWorking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xmlPath
            // 
            this.xmlPath.HeaderText = "xml路徑";
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.ReadOnly = true;
            this.xmlPath.Visible = false;
            // 
            // subTaskSeriNo
            // 
            this.subTaskSeriNo.HeaderText = "subTaskSeriNo";
            this.subTaskSeriNo.Name = "subTaskSeriNo";
            this.subTaskSeriNo.Visible = false;
            // 
            // empID_
            // 
            this.empID_.HeaderText = "員編";
            this.empID_.Name = "empID_";
            // 
            // workNo_
            // 
            this.workNo_.HeaderText = "工單號碼";
            this.workNo_.Name = "workNo_";
            // 
            // uidB5_
            // 
            this.uidB5_.HeaderText = "車號後五碼";
            this.uidB5_.Name = "uidB5_";
            // 
            // taskDes_
            // 
            this.taskDes_.HeaderText = "工作說明";
            this.taskDes_.Name = "taskDes_";
            this.taskDes_.Width = 150;
            // 
            // startDate_
            // 
            this.startDate_.HeaderText = "開工時間";
            this.startDate_.Name = "startDate_";
            this.startDate_.Width = 130;
            // 
            // endDate_
            // 
            this.endDate_.HeaderText = "收工時間";
            this.endDate_.Name = "endDate_";
            this.endDate_.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.endDate_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.endDate_.Width = 130;
            // 
            // costTime_
            // 
            this.costTime_.HeaderText = "耗費時間";
            this.costTime_.Name = "costTime_";
            this.costTime_.ReadOnly = true;
            // 
            // dataGridViewButtonColumn2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = "儲存編輯";
            this.dataGridViewButtonColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewButtonColumn2.HeaderText = "";
            this.dataGridViewButtonColumn2.Name = "dataGridViewButtonColumn2";
            this.dataGridViewButtonColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // xmlPath_
            // 
            this.xmlPath_.HeaderText = "xml路徑";
            this.xmlPath_.Name = "xmlPath_";
            this.xmlPath_.ReadOnly = true;
            this.xmlPath_.Visible = false;
            // 
            // subTaskSeriNo_
            // 
            this.subTaskSeriNo_.HeaderText = "subTaskSeriNo";
            this.subTaskSeriNo_.Name = "subTaskSeriNo_";
            this.subTaskSeriNo_.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workingList_DataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workedList_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        

        

        #endregion

        private System.Windows.Forms.TextBox textBox_empID;
        private System.Windows.Forms.TextBox textBox_workNo;
        private System.Windows.Forms.TextBox textBox_uidB5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView workingList_DataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox_taskDes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView workedList_DataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidB5;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
        private System.Windows.Forms.DataGridViewButtonColumn stopWork;
        private System.Windows.Forms.DataGridViewButtonColumn saveWorking;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTaskSeriNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn empID_;
        private System.Windows.Forms.DataGridViewTextBoxColumn workNo_;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidB5_;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskDes_;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate_;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDate_;
        private System.Windows.Forms.DataGridViewTextBoxColumn costTime_;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn xmlPath_;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTaskSeriNo_;
    }
}

