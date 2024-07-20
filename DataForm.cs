using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.CSharp;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;


namespace Mr_Hajiani
{
    public partial class DataForm : Form
    {
        private DataTable dt;
        private DataView dv;
        private List<DataListView> listData;

        public DataForm()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("R");
            dt.Columns.Add("Time");
            dt.Columns.Add("Voltage");

            dv = new DataView(dt);
            populateDataListViewItem(dv);
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.AllowColumnReorder = false;

            cmbRange.SelectedItem = cmbRange.Items[1];
        }
        public void SetData(string Round, string time, string volt)
        {
            FillDataTable(GenrateData(Round, time, volt));

            dv = new DataView(dt);
            populateDataListViewItem(dv);
        }

        public void RemoveAll()
        {
            dt.Rows.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog svFile = new SaveFileDialog();
            svFile.Filter = "Excel File | *.xlsx";
            if (svFile.ShowDialog() == DialogResult.OK)
            {
                Excel.Application exeExcel = new Excel.Application();
                Excel.Workbook workbook = exeExcel.Workbooks.Add("");
                Excel.Sheets shet = workbook.Sheets;
                Excel.Worksheet worksheet = shet.Add(shet[1]);
                worksheet.Name = "Data";
                Excel.Range exRange = worksheet.UsedRange;
                worksheet.DisplayRightToLeft = true;

                int g = 0;
                while (g < listView1.Columns.Count)
                {
                    exRange.Cells[1, g + 1] = listView1.Columns[g].Text;
                    g++;
                }

                int i = 1;
                int j = 1;
                progressBar1.Maximum = listView1.Items.Count;
                foreach (ListViewItem listviewitem in listView1.Items)
                {
                    i = 1;
                    foreach (ListViewItem.ListViewSubItem listviewsub in listviewitem.SubItems)
                    {
                        exRange.Cells[j + 1, i] = listviewsub.Text;
                        i++;
                    }
                    progressBar1.Value++;
                    j++;
                }
                workbook.SaveAs(svFile.FileName);
                exeExcel.Quit();
                MessageBox.Show("Save Done !", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbRange.Text == "Time")
            {
                dv.RowFilter = string.Format("Time Like '%{0}%'", txtSearch.Text);
            }
            else if (cmbRange.Text == "Voltage")
            {
                dv.RowFilter = string.Format("Voltage Like '%{0}%'", txtSearch.Text);
            }

            populateDataListViewItem(dv);
        }

        void FillDataTable(List<DataListView> listData)
        {
            foreach (var v in listData)
            {
                dt.Rows.Add(v.Row, v.Time, v.Voltage);

            }
        }

        void populateDataListViewItem(DataView dataV)
        {
            listView1.Items.Clear();
            foreach (DataRow row in dataV.ToTable().Rows)
            {
                listView1.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
            }
        }
        List<DataListView> GenrateData(string radif, string zaman, string vol)
        {
            listData = new List<DataListView>()
            {
                new DataListView(radif, zaman, vol)
            };

            return listData;
        }
    }
}
public class DataListView
{
    private string row;
    private string time;
    private string voltage;

    public DataListView(string row, string time, string voltage)
    {
        this.row = row;
        this.time = time;
        this.voltage = voltage;

    }
    public string Row
    { get { return row; } }

    public string Time { get { return time; } }

    public string Voltage { get { return voltage; } }
}
