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
using System.Threading;
using System.IO;
using ExcelDataReader;

namespace ZetaPotential
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string[] portNames = System.IO.Ports.SerialPort.GetPortNames();
        string dtMasuk;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= portNames.Length - 1; i++)
            {
                comboBoxPortList.Items.Add(portNames[i]);
            }
            if (portNames.Length >= 1)
            {
                comboBoxPortList.Text = Convert.ToString(comboBoxPortList.Items[0]);
            }
            dataGridView1.ColumnCount = 7;
            string[] row = new string[] { "Time", "pH", "Color (RGB)", "Conductivity (uS/cm)", "Temperature (°C)", "Turbidity (NTU) ", "Zeta Potential (mv)" };
            dataGridView1.Rows.Insert(0, row);
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = false;
            // serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(DataReceived);

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPortList.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBaudrates.Text);
                serialPort1.Open();
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = true;
                panelControl.Enabled = true;


            }
            catch (Exception ex)
            {
                serialPort1.Close();
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                buttonConnect.Enabled = true;
                buttonDisconnect.Enabled = false;
                panelControl.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void button_Save_Click(object sender, EventArgs e)
        {

            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Microsoft.Office.Interop.Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range CR = (Microsoft.Office.Interop.Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            xlWorkSheet.Columns.AutoFit();
        }

        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
            {
                Clipboard.SetDataObject(dataObj);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");

            string[] row = new string[] { date, PHValue.Text, ColorValue.Text, ConductivityValue.Text, TemperatureValue.Text, TurbidityValue.Text, ZetaValue.Text };
            dataGridView1.Rows.Insert(1, row);
            //dataGridView1.Rows.Add(date, label_PH.Text, label_Color.Text, label_conductivity.Text, label_temperature.Text, label_turbidity.Text, textboxZetaValue.Text);

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // dataIn = serialPort1.ReadLine();
                this.Invoke(new EventHandler(updateData));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateData(object sender, EventArgs e)
        {
            dtMasuk += serialPort1.ReadExisting();
            Console.WriteLine(dtMasuk);
            if (dtMasuk.Length >=35)
            {
               // Console.WriteLine(dtMasuk);
                string data = dtMasuk;
                //string[] splitNow = System.Text.RegularExpressions.Regex.Split(data.Substring(0, data.Length - 0), "#");
                string[] splitNow = dtMasuk.Split('@', '#');
                string inidata1 = splitNow[1];
                string inidata2 = splitNow[2];
                string inidata3 = splitNow[3];
                string inidata4 = splitNow[4];
                string inidata5 = splitNow[5];


                PHValue.Text = inidata1;
                ColorValue.Text = inidata2;
                TemperatureValue.Text = inidata3;
                ConductivityValue.Text = inidata4;
                TurbidityValue.Text = inidata5;
                dtMasuk = "";
            }

        }

        private void ZetaValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
