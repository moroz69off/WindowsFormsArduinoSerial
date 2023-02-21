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

namespace WindowsFormsArduinoSerial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Open port")
            {
                try
                {
                    serialPort.PortName = comboBox.Text;
                    serialPort.Open();
                    buttonConnect.Text = "Close port";
                    comboBox.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonConnect.Text == "Close port")
            {
                serialPort.Close();
                buttonConnect.Text = "Open port";
                comboBox.Enabled = true;
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serial = sender as SerialPort;
            labelVoltage.Text = serial.ReadLine();
        }

        private void buttonGetPorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox.Text = "";
            comboBox.Items.Clear();
            if (ports.Length != 0)
            {
                comboBox.Items.AddRange(ports);
                comboBox.SelectedIndex = ports.Length - 1;
            }
        }
    }
}
