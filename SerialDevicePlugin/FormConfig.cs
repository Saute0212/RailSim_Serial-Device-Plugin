using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialDevicePlugin
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
            string[] ComSpeed = {"300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200"};
            ComSpeedList.Items.AddRange( ComSpeed );
            label2.Text = "Failed";
            ReadingComPorts();
        }

        //接続されているCOMポートの読み込み
        public void ReadingComPorts()
        {
            ComPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                ComPorts.Items.Add(port);
            }
        }

        //"更新"が押された際にCOMポートを再度読み込み
        private void Reloading_Click(object sender, EventArgs e)
        {
            ReadingComPorts();
        }

        //マイコンとの接続確認
        private void ConfirmConnection_Click(object sender, EventArgs e)
        {

        }

        //"OK"がクリック
        private void Ok_Click(object sender, EventArgs e)
        {

        }

        //"Cancel"がクリック
        private void Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
