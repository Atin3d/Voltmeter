using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Mr_Hajiani
{
    public partial class Form1 : Form
    {
        string[] PortName;
        bool flagConeect = false;
        public bool exFlag = false;
        private int hours, minutes, seconds = 0;
        private int DayEx, hoursEx, minutesEx, secondsEx = 0;
        private int DayBase, HourBase, MinBase = 0;
        private int Rad = 1;
        ChartForm Chart_Form;
        DataForm Data_Form;

        public Form1()
        {
            InitializeComponent();

            PortName = SerialPort.GetPortNames();
            Chart_Form = new ChartForm();
            Data_Form = new DataForm();
            foreach (string p in PortName)
            {
                cmbPort.Items.Add(p);

            }
            cmbPort.SelectedItem = PortName[0];
            cmbRate.SelectedItem = cmbRate.Items[6];
            cmbData.SelectedItem = cmbData.Items[1];
            NumData.Value = 1;

        }

        private void timCon_Tick(object sender, EventArgs e)
        {
            if (seconds == 60)
            {
                seconds = 0;
                if (minutes == 60)
                {
                    minutes = 0;
                    hours++;
                }
                else
                {
                    minutes++;
                }
            }
            else
            {
                seconds++;
            }

            if (exFlag == true)
            {
                if (Port.IsOpen)
                {
                    try
                    {
                        switch (cmbData.SelectedItem)
                        {
                            case 0://DAY
                                if (DayEx == DayBase)
                                {
                                    Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, lblVolt.Text + "v");
                                    Rad++;
                                    string volt = lblVolt.Text;
                                    Chart_Form.SetChart(lblTimeTest.Text, volt);
                                }
                                break;//HOUR
                            case 1:
                                if (hoursEx == HourBase)
                                {
                                    Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, lblVolt.Text + "v");
                                    Rad++;
                                    string volt = lblVolt.Text;
                                    Chart_Form.SetChart(lblTimeTest.Text, volt);
                                }
                                break;
                            case 2://MINUTES
                                if (minutesEx == MinBase)
                                {
                                    Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, lblVolt.Text + "v");
                                    Rad++;
                                    string volt = lblVolt.Text;
                                    Chart_Form.SetChart(lblTimeTest.Text, volt);
                                }
                                break;

                        }
                    }
                    catch { }

                }

                if (secondsEx == 59)
                {
                    secondsEx = 1;
                    if (minutesEx == 59)
                    {
                        minutesEx = 0;

                        if (hoursEx == 23)
                        {
                            hoursEx = 0;
                            DayEx++;
                        }
                        else
                        {
                            hoursEx++;
                        }
                    }
                    else
                    {
                        minutesEx++;
                    }
                    string volt;
                    switch (cmbData.GetItemText(cmbData.SelectedItem).ToLower())
                    {
                        case "day"://DAY
                            volt = lblVolt.Text;
                            Rad++;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;//HOUR
                        case "hour":
                            Rad++;
                            volt = lblVolt.Text;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;
                        case "min"://MINUTES
                            Rad++;
                            volt = lblVolt.Text;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;
                    }
                }
                else
                {
                    secondsEx++;
                }
                if (chkFree.Checked == false)
                {
                    if (minutesEx >= int.Parse(NumMin.Value.ToString()) && hoursEx >= int.Parse(NumHur.Value.ToString()) && DayEx >= int.Parse(NumDay.Value.ToString()))
                    {
                        secondsEx = 0;
                        minutesEx = 0;
                        hoursEx = 0;
                        DayEx = 0;
                        exFlag = false;
                        NumDay.Enabled = true;
                        NumHur.Enabled = true;
                        NumMin.Enabled = true;
                        lblTimeTest.ForeColor = Color.Black;
                        MessageBox.Show("Test Ended", "End", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }

            lblConTime.Text = (hours > 9 ? hours + "" : "0" + hours) + ":"
                + (minutes > 9 ? minutes + "" : "0" + minutes) + ":"
                + (seconds > 9 ? seconds + "" : "0" + seconds);

            lblTimeTest.Text = (DayEx > 9 ? DayEx + "" : "0" + DayEx) + ":" + 
                (hoursEx > 9 ? hoursEx + "" : "0" + hoursEx) + ":"
                + (minutesEx > 9 ? minutesEx + "" : "0" + minutesEx) + ":"
                + (secondsEx > 9 ? secondsEx + "" : "0" + secondsEx);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (flagConeect == false)
                {
                    hours = 0;
                    minutes = 0;
                    seconds = 0;
                    connectToArduino();
                    timCon.Enabled = true;
                    cmbRate.Enabled = false;
                    cmbPort.Enabled = false;

                }
            }
           catch { flagConeect = false; MessageBox.Show("Error Port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (flagConeect == true)
            {
                DisconnectArduino();
                lblConTime.Text = "00:00:00";
                exFlag = false;
                timCon.Stop();
                secondsEx = 0;
                minutesEx = 0;
                hoursEx = 0;
                exFlag = false;
                NumDay.Enabled = true;
                NumHur.Enabled = true;
                NumMin.Enabled = true;
                lblTimeTest.ForeColor = Color.Black;
                lblVolt.Text = "0.0";
                cmbRate.Enabled = true;
                cmbPort.Enabled = true;
            }
            else
            {
                MessageBox.Show("Connection Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(flagConeect)
            {
                if (NumMin.Value == 0 && NumHur.Value == 0 && NumDay.Value == 0 && chkFree.Checked == false)
                {
                    MessageBox.Show("Please Check Time Test", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    hoursEx = 0;
                    minutesEx = 0;
                    secondsEx = 0;
                    Rad = 0;
                    Data_Form.listView1.Items.Clear();
                    Data_Form.RemoveAll();

                    NumDay.Enabled = false;
                    NumHur.Enabled = false;
                    NumMin.Enabled = false;
                    NumData.Enabled = false;
                    cmbData.Enabled = false;
                    lblTimeTest.ForeColor = Color.Green;
                    Chart_Form.chart1.Series["VoltPerSec"].Points.Clear();

                    string volt;
                    switch (cmbData.GetItemText(cmbData.SelectedItem).ToLower())
                    {
                        case "day"://DAY
                            volt = lblVolt.Text;
                            Rad++;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;//HOUR
                        case "hour":
                            Rad++;
                            volt = lblVolt.Text;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;
                        case "min"://MINUTES
                            Rad++;
                            volt = lblVolt.Text;
                            Data_Form.SetData(Rad.ToString(), lblTimeTest.Text, volt + "v");
                            Chart_Form.SetChart(volt, lblTimeTest.Text);
                            break;
                    }

                    exFlag = true;
                }
            }
        }

        private void NumData_ValueChanged(object sender, EventArgs e)
        {


            switch (cmbData.GetItemText(cmbData.SelectedItem).ToLower())
            {
                case "day"://DAY
                    DayBase = int.Parse(NumData.Value.ToString());
                    if (NumData.Value <= 0)
                    {
                     
                        cmbData.SelectedItem = cmbData.Items[1];
                        NumData.Value = 23;
                    }
                    break;//HOUR
                case "hour":
                    HourBase = int.Parse(NumData.Value.ToString());
                    if (NumData.Value > 23)
                    {
                      
                        cmbData.SelectedItem = cmbData.Items[0];
                        NumData.Value = 1;
                    }
                    if (NumData.Value <= 0)
                    {
                       
                        cmbData.SelectedItem = cmbData.Items[2];
                        NumData.Value = 59;
                    }
                    break;
                case "min"://MINUTES
                    MinBase = int.Parse(NumData.Value.ToString());
                    if (NumData.Value > 59)
                    {
                        NumData.Value = 1;
                        cmbData.SelectedItem = cmbData.Items[1];
                    }
                    if (NumData.Value <= 0)
                    {
                        NumData.Value = 1;
                    }
                    break;
            }
        }

        private void cmbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbData.GetItemText(cmbData.SelectedItem).ToLower())
            {
                case "day"://DAY
                    NumData.Value = 1;
                    break;//HOUR
                case "hour":
                    NumData.Value = 23;
                    break;
                case "min"://MINUTES
                    NumData.Value = 59;
                    break;
            }
        }

        private void chkFree_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFree.Checked)
            {
                NumDay.Enabled = false;
                NumHur.Enabled = false;
                NumMin.Enabled = false;
            }   
            else
            {
                NumDay.Enabled = true;
                NumHur.Enabled = true;
                NumMin.Enabled = true;
            }
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart_Form.ShowDialog();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            Data_Form.ShowDialog();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(exFlag)
            {
                exFlag = false;
                DayEx = 0;
                hoursEx = 0;
                minutesEx = 0;
                secondsEx = 0;
                Rad = 1;
                NumDay.Enabled = true;
                NumHur.Enabled = true;
                NumMin.Enabled = true;
                NumData.Enabled = true;
                cmbData.Enabled = true;

                lblTimeTest.Text = (DayEx > 9 ? DayEx + "" : "0" + DayEx) + ":" +
                    (hoursEx > 9 ? hoursEx + "" : "0" + hoursEx) + ":"
                    + (minutesEx > 9 ? minutesEx + "" : "0" + minutesEx) + ":"
                    + (secondsEx > 9 ? secondsEx + "" : "0" + secondsEx);
                lblTimeTest.ForeColor = Color.Red;
            }
            else 
            {
                MessageBox.Show("Test Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cmbPort_MouseClick(object sender, MouseEventArgs e)
        {
            PortName = SerialPort.GetPortNames();
            cmbPort.Items.Clear();
            foreach (string p in PortName)
            {
                cmbPort.Items.Add(p);

            }
        }

        void connectToArduino()
        {
            flagConeect = true;
            string selectedPort = cmbPort.GetItemText(cmbPort.SelectedItem);
            int selectedBaud = int.Parse(cmbRate.GetItemText(cmbRate.SelectedItem));
            Port.BaudRate = selectedBaud;
            Port.PortName = selectedPort;
            Port.Parity = Parity.None;
            Port.StopBits = StopBits.Two;
            Port.DataBits = 8;
            Port.DataReceived += Port_DataReceived;
            Port.Open();

            Port.Write("AYR");
            lblport.Text = "Port Status : Open";
            lblport.ForeColor = Color.Green;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                SerialPort spL = (SerialPort)sender;
                string data = spL.ReadLine();
                if (data.ToLower().StartsWith("YES".ToLower()))
                {
                    Port.Write("OK");

                }
                if (data.ToLower().StartsWith("OK".ToLower()))
                {
                    flagConeect = true;
                    btnStart.Enabled = true;
                    btnStop.Enabled = true;
                    lblboard.Text = "Board Status : Connected";
                    lblboard.ForeColor = Color.Green;
                    NumData.Enabled = true;
                    cmbData.Enabled = true;

                }
                if (data.ToLower().StartsWith("v:"))
                {
                    string voltage = data.Substring(2);
                    if (voltage != String.Empty)
                    {
                        lblVolt.Text = voltage;
                    }
                }
            }
            catch { }
        }

        void DisconnectArduino()
        {
            flagConeect = false;
            Port.Close();
            lblport.Text = "Port Status : Close";
            lblport.ForeColor = Color.Red;
            lblboard.Text = "Board Status: Disconnected";
            lblboard.ForeColor = Color.Red;
        }

    }
}
