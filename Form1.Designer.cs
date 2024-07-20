namespace Mr_Hajiani
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblboard = new System.Windows.Forms.Label();
            this.lblport = new System.Windows.Forms.Label();
            this.lblConTime = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRate = new System.Windows.Forms.ComboBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFree = new System.Windows.Forms.CheckBox();
            this.NumData = new System.Windows.Forms.NumericUpDown();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVolt = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTimeTest = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumMin = new System.Windows.Forms.NumericUpDown();
            this.NumHur = new System.Windows.Forms.NumericUpDown();
            this.NumDay = new System.Windows.Forms.NumericUpDown();
            this.Port = new System.IO.Ports.SerialPort(this.components);
            this.timCon = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDay)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblboard);
            this.groupBox1.Controls.Add(this.lblport);
            this.groupBox1.Controls.Add(this.lblConTime);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbRate);
            this.groupBox1.Controls.Add(this.cmbPort);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(248, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label3.Location = new System.Drawing.Point(59, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time : ";
            // 
            // lblboard
            // 
            this.lblboard.AutoSize = true;
            this.lblboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblboard.ForeColor = System.Drawing.Color.Red;
            this.lblboard.Location = new System.Drawing.Point(42, 129);
            this.lblboard.Name = "lblboard";
            this.lblboard.Size = new System.Drawing.Size(156, 17);
            this.lblboard.TabIndex = 8;
            this.lblboard.Text = "Board Status : Disconnect";
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblport.ForeColor = System.Drawing.Color.Red;
            this.lblport.Location = new System.Drawing.Point(57, 109);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(114, 17);
            this.lblport.TabIndex = 7;
            this.lblport.Text = "Port Status : Close";
            // 
            // lblConTime
            // 
            this.lblConTime.AutoSize = true;
            this.lblConTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConTime.Location = new System.Drawing.Point(115, 89);
            this.lblConTime.Name = "lblConTime";
            this.lblConTime.Size = new System.Drawing.Size(56, 17);
            this.lblConTime.TabIndex = 1;
            this.lblConTime.Text = "00:00:00";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(124, 63);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(93, 23);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "close";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 63);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(93, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "open";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port ";
            // 
            // cmbRate
            // 
            this.cmbRate.FormattingEnabled = true;
            this.cmbRate.Items.AddRange(new object[] {
            "300",
            "600",
            "750",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "500000",
            "921600",
            "1000000",
            "2000000"});
            this.cmbRate.Location = new System.Drawing.Point(124, 37);
            this.cmbRate.Name = "cmbRate";
            this.cmbRate.Size = new System.Drawing.Size(93, 21);
            this.cmbRate.TabIndex = 1;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(25, 37);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(93, 21);
            this.cmbPort.TabIndex = 0;
            this.cmbPort.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbPort_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkFree);
            this.groupBox2.Controls.Add(this.NumData);
            this.groupBox2.Controls.Add(this.cmbData);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblVolt);
            this.groupBox2.Controls.Add(this.btnData);
            this.groupBox2.Controls.Add(this.btnChart);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblTimeTest);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NumMin);
            this.groupBox2.Controls.Add(this.NumHur);
            this.groupBox2.Controls.Add(this.NumDay);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 202);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test Status";
            // 
            // chkFree
            // 
            this.chkFree.AutoSize = true;
            this.chkFree.Location = new System.Drawing.Point(180, 39);
            this.chkFree.Name = "chkFree";
            this.chkFree.Size = new System.Drawing.Size(48, 17);
            this.chkFree.TabIndex = 19;
            this.chkFree.Text = "Free";
            this.chkFree.UseVisualStyleBackColor = true;
            this.chkFree.CheckedChanged += new System.EventHandler(this.chkFree_CheckedChanged);
            // 
            // NumData
            // 
            this.NumData.Enabled = false;
            this.NumData.Location = new System.Drawing.Point(175, 139);
            this.NumData.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumData.Name = "NumData";
            this.NumData.Size = new System.Drawing.Size(42, 22);
            this.NumData.TabIndex = 18;
            this.NumData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumData.ValueChanged += new System.EventHandler(this.NumData_ValueChanged);
            // 
            // cmbData
            // 
            this.cmbData.Enabled = false;
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Items.AddRange(new object[] {
            "day",
            "hour",
            "min"});
            this.cmbData.Location = new System.Drawing.Point(84, 138);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(85, 21);
            this.cmbData.TabIndex = 17;
            this.cmbData.SelectedIndexChanged += new System.EventHandler(this.cmbData_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Data Per :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(199, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "v";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Test Time :";
            // 
            // lblVolt
            // 
            this.lblVolt.AutoSize = true;
            this.lblVolt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVolt.Location = new System.Drawing.Point(140, 158);
            this.lblVolt.Name = "lblVolt";
            this.lblVolt.Size = new System.Drawing.Size(53, 37);
            this.lblVolt.TabIndex = 13;
            this.lblVolt.Text = "0.0";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(123, 109);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(116, 23);
            this.btnData.TabIndex = 12;
            this.btnData.Text = "Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(11, 109);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(112, 23);
            this.btnChart.TabIndex = 11;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(18, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 37);
            this.label10.TabIndex = 10;
            this.label10.Text = "Voltage :";
            // 
            // lblTimeTest
            // 
            this.lblTimeTest.AutoSize = true;
            this.lblTimeTest.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTest.Location = new System.Drawing.Point(117, 63);
            this.lblTimeTest.Name = "lblTimeTest";
            this.lblTimeTest.Size = new System.Drawing.Size(73, 17);
            this.lblTimeTest.TabIndex = 9;
            this.lblTimeTest.Text = "00:00:00:00";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(123, 83);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(11, 83);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(120, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Minutes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Hour";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Day";
            // 
            // NumMin
            // 
            this.NumMin.Location = new System.Drawing.Point(124, 38);
            this.NumMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NumMin.Name = "NumMin";
            this.NumMin.Size = new System.Drawing.Size(42, 22);
            this.NumMin.TabIndex = 2;
            this.NumMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumHur
            // 
            this.NumHur.Location = new System.Drawing.Point(73, 38);
            this.NumHur.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.NumHur.Name = "NumHur";
            this.NumHur.Size = new System.Drawing.Size(42, 22);
            this.NumHur.TabIndex = 1;
            this.NumHur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumDay
            // 
            this.NumDay.Location = new System.Drawing.Point(22, 38);
            this.NumDay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumDay.Name = "NumDay";
            this.NumDay.Size = new System.Drawing.Size(42, 22);
            this.NumDay.TabIndex = 0;
            this.NumDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timCon
            // 
            this.timCon.Interval = 1000;
            this.timCon.Tick += new System.EventHandler(this.timCon_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 390);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Voltmeter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblboard;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.Label lblConTime;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRate;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NumDay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumMin;
        private System.Windows.Forms.NumericUpDown NumHur;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTimeTest;
        private System.IO.Ports.SerialPort Port;
        private System.Windows.Forms.Timer timCon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVolt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkFree;
        private System.Windows.Forms.NumericUpDown NumData;
        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.Label label9;
    }
}

