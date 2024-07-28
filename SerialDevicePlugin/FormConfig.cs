﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialDevicePlugin
{
    public partial class FormConfig : Form
    {
        string[] NumList = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] ComSpeed = { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200" };
        private string[] cabSwitchKeyTexts = { "Horn 1", "Horn 2", "Constant Speed Control", "Music Horn" };
        private string[] atsKeyTexts = new string[16];
        private List<int[]> keyCodeTable = new List<int[]>();

        public FormConfig()
        {
            InitializeComponent();
            //フォームのサイズ指定
            MinimumSize = new Size(475, 505);
            MaximumSize = new Size(475, 505);

            //読み込み時に実行する関数
            ReadingComPorts();
            SetUp();
        }

        //接続されているCOMポートの読み込み
        private void ReadingComPorts()
        {
            ComPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ports = ComPortsFormatter("COM", ports, NumList);
            foreach (string port in ports)
            {
                ComPorts.Items.Add(port);
            }
        }

        //初期設定関数
        private void SetUp()
        {
            //ComboBox・Label初期設定
            for(int i = 0; i < atsKeyTexts.Length; i++)
            {
                atsKeyTexts[i] = "ATS" + i.ToString();
            }
            ComSpeedList.Items.AddRange(ComSpeed);
            label2.Text = "Failed";

            //初期設定
            for(int i = 0; i < cabSwitchKeyTexts.Length; i++)
            {
                AddKey(cabSwitchKeyTexts[i]);
                keyCodeTable.Add(new int[2] { -1, i });
            }

            for(int i = 0; i < atsKeyTexts.Length; i++)
            {
                AddKey(atsKeyTexts[i]);
                keyCodeTable.Add(new int[2] { -2, i });
            }

            SelectComPort(ComPorts, SerialDevicePlugin.settings.Port);
            SelectComSpeed(ComSpeedList, ComSpeed, SerialDevicePlugin.settings.Speed.ToString());
            SelectDropDownList(Btn1List, SerialDevicePlugin.settings.Button1);
            SelectDropDownList(Btn2List, SerialDevicePlugin.settings.Button2);
            SelectDropDownList(Btn3List, SerialDevicePlugin.settings.Button3);
            SelectDropDownList(Btn4List, SerialDevicePlugin.settings.Button4);
            SelectDropDownList(Btn5List, SerialDevicePlugin.settings.Button5);
            SelectDropDownList(Btn6List, SerialDevicePlugin.settings.Button6);
            SelectDropDownList(Btn7List, SerialDevicePlugin.settings.Button7);
            SelectDropDownList(Btn8List, SerialDevicePlugin.settings.Button8);
            SelectDropDownList(Btn9List, SerialDevicePlugin.settings.Button9);
            SelectDropDownList(Btn10List, SerialDevicePlugin.settings.Button10);
            SelectDropDownList(Btn11List, SerialDevicePlugin.settings.Button11);
            SelectDropDownList(Btn12List, SerialDevicePlugin.settings.Button12);
            SelectDropDownList(Btn13List, SerialDevicePlugin.settings.Button13);
            SelectDropDownList(Btn14List, SerialDevicePlugin.settings.Button14);
            SelectDropDownList(Btn15List, SerialDevicePlugin.settings.Button15);
            SelectDropDownList(Btn16List, SerialDevicePlugin.settings.Button16);
            SelectDropDownList(Btn17List, SerialDevicePlugin.settings.Button17);
            SelectDropDownList(Btn18List, SerialDevicePlugin.settings.Button18);
            SelectDropDownList(Btn19List, SerialDevicePlugin.settings.Button19);
            SelectDropDownList(Btn20List, SerialDevicePlugin.settings.Button20);
        }

        //COMポート用にフォーマットを修正(.NET Framework 3.5のバグ対応用)
        private string[] ComPortsFormatter(string prefix, string[] str, string[] list)
        {
            if (prefix == null) throw new ArgumentNullException(nameof(prefix));
            if (str == null) throw new ArgumentNullException(nameof (str));
            if (list == null) throw new ArgumentNullException(nameof(list));

            string[] result = new string[str.Length];
            int index = 0;

            foreach(string element in str)
            {
                string tmp = "";
                for(int i = 3; i < element.Length; i++)
                {
                    for(int j = 0; j < list.Length; j++)
                    {
                        if (element[i].ToString() == list[j])
                        {
                            tmp += element[i].ToString();
                        }
                    }
                }
                result[index] = prefix + tmp;
                index++;
            }

            if(result != null)
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        //COMポートをComboBoxから探索・設定
        private void SelectComPort(ComboBox list, string target)
        {
            bool ItemFound = false;
            int cnt = 0;

            foreach(string element in list.Items)
            {
                if(element == target)
                {
                    list.SelectedIndex = cnt;
                    ItemFound = true;
                    break;
                }
                cnt++;
            }

            if(!ItemFound)
            {
                list.SelectedIndex = -1;
            }
        }

        //COMの通信速度をComboBoxから探索・設定
        private void SelectComSpeed(ComboBox list, string[] src, string target)
        {
            bool ItemFound = false;
            int cnt = 0;

            foreach(string element in src)
            {
                if(element == target)
                {
                    list.SelectedIndex = cnt;
                    ItemFound = true;
                    break;
                }
                cnt++;
            }

            if(!ItemFound)
            {
                list.SelectedIndex = -1;
            }
        }

        //ComboBoxへアイテムの追加
        private void AddKey(string s)
        {
            Btn1List.Items.Add(s);
            Btn2List.Items.Add(s);
            Btn3List.Items.Add(s);
            Btn4List.Items.Add(s);
            Btn5List.Items.Add(s);
            Btn6List.Items.Add(s);
            Btn7List.Items.Add(s);
            Btn8List.Items.Add(s);
            Btn9List.Items.Add(s);
            Btn10List.Items.Add(s);
            Btn11List.Items.Add(s);
            Btn12List.Items.Add(s);
            Btn13List.Items.Add(s);
            Btn14List.Items.Add(s);
            Btn15List.Items.Add(s);
            Btn16List.Items.Add(s);
            Btn17List.Items.Add(s);
            Btn18List.Items.Add(s);
            Btn19List.Items.Add(s);
            Btn20List.Items.Add(s);
        }

        //設定の呼び出し・各設定項目に反映
        private void SelectDropDownList(ComboBox list, int[] assign)
        {
            switch(assign[0])
            {
                case -1:
                    if (assign[1] >= 0 && assign[1] < cabSwitchKeyTexts.Length)
                    {
                        list.SelectedIndex = assign[1];
                    }
                    break;
                case -2:
                    if (assign[1] >= 0 && assign[1] < atsKeyTexts.Length)
                    {
                        list.SelectedIndex = assign[1] + cabSwitchKeyTexts.Length;
                    }
                    break;
            }
        }

        //"更新"が押された際にCOMポートを再度読み込み
        private void Reloading_Click(object sender, EventArgs e)
        {
            ReadingComPorts();
            SelectComPort(ComPorts, SerialDevicePlugin.settings.Port);
        }

        //マイコンとの接続確認
        private void ConfirmConnection_Click(object sender, EventArgs e)
        {
            SerialPort TestPort = null;
            bool ConnectionSuccess = false;

            if (ComPorts.SelectedIndex >= 0 && ComSpeedList.SelectedIndex >= 0)
            {
                try
                {
                    TestPort = new SerialPort(ComPorts.SelectedItem.ToString(), int.Parse(ComSpeedList.SelectedItem.ToString()), Parity.None, 8, StopBits.One);
                    TestPort.Open();
                    TestPort.Write("SerialDevicePlugin\n");
                    TestPort.Close();
                    TestPort = null;
                    ConnectionSuccess = true;
                }
                catch (Exception ex)
                {
                    try
                    {
                        TestPort.Close();
                    }
                    catch
                    {
                    }

                    ConnectionSuccess = false;
                    MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(ConnectionSuccess)
            {
                label2.Text = "Success";
            }
            else
            {
                label2.Text = "Failure";
            }
        }

        //"OK"がクリック
        private void Ok_Click(object sender, EventArgs e)
        {
            if(ComPorts.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Port = (string)ComPorts.SelectedItem;
            }
            else
            {
                SerialDevicePlugin.settings.Port = "COM0";
            }

            if(ComSpeedList.SelectedIndex >= 0 && ComSpeedList.SelectedIndex <= 10)
            {
                SerialDevicePlugin.settings.Speed = int.Parse(ComSpeedList.SelectedItem.ToString());
            }

            if(Btn1List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button1 = keyCodeTable[Btn1List.SelectedIndex];
            }
            if (Btn2List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button2 = keyCodeTable[Btn2List.SelectedIndex];
            }
            if (Btn3List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button3 = keyCodeTable[Btn3List.SelectedIndex];
            }
            if (Btn4List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button4 = keyCodeTable[Btn4List.SelectedIndex];
            }
            if (Btn5List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button5 = keyCodeTable[Btn5List.SelectedIndex];
            }
            if (Btn6List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button6 = keyCodeTable[Btn6List.SelectedIndex];
            }
            if (Btn7List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button7 = keyCodeTable[Btn7List.SelectedIndex];
            }
            if (Btn8List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button8 = keyCodeTable[Btn8List.SelectedIndex];
            }
            if (Btn9List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button9 = keyCodeTable[Btn9List.SelectedIndex];
            }
            if (Btn10List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button10 = keyCodeTable[Btn10List.SelectedIndex];
            }
            if (Btn11List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button11 = keyCodeTable[Btn11List.SelectedIndex];
            }
            if (Btn12List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button12 = keyCodeTable[Btn12List.SelectedIndex];
            }
            if (Btn13List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button13 = keyCodeTable[Btn13List.SelectedIndex];
            }
            if (Btn14List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button14 = keyCodeTable[Btn14List.SelectedIndex];
            }
            if (Btn15List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button15 = keyCodeTable[Btn15List.SelectedIndex];
            }
            if (Btn16List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button16 = keyCodeTable[Btn16List.SelectedIndex];
            }
            if (Btn17List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button17 = keyCodeTable[Btn17List.SelectedIndex];
            }
            if (Btn18List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button18 = keyCodeTable[Btn18List.SelectedIndex];
            }
            if (Btn19List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button19 = keyCodeTable[Btn19List.SelectedIndex];
            }
            if (Btn20List.SelectedIndex >= 0)
            {
                SerialDevicePlugin.settings.Button20 = keyCodeTable[Btn20List.SelectedIndex];
            }

            DialogResult = DialogResult.OK;

            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //"Cancel"がクリック
        private void Cancel_Click(object sender, EventArgs e)
        {
            //フォームを閉じる
            try
            {
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
