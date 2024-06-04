using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace SerialDevicePlugin
{
    public class Settings
    {
        private const string filename = "SerialDevicePlugin.xml"; //ファイル名の指定
        private string directory = string.Empty; //ディレクトリ

        private int port = 0; //COMポート番号
        private int speed = 9600; //シリアル通信速度

        //各ボタンの設定
        private int[] button1  = { -1, 0 };
        private int[] button2  = { -1, 1 };
        private int[] button3  = { -1, 2 };
        private int[] button4  = { -1, 3 };
        private int[] button5  = { -2, 0 };
        private int[] button6  = { -2, 1 };
        private int[] button7  = { -2, 2 };
        private int[] button8  = { -2, 3 };
        private int[] button9  = { -2, 4 };
        private int[] button10 = { -2, 5 };
        private int[] button11 = { -2, 6 };
        private int[] button12 = { -2, 7 };
        private int[] button13 = { -2, 8 };
        private int[] button14 = { -2, 9 };
        private int[] button15 = { -2, 10 };
        private int[] button16 = { -2, 11 };
        private int[] button17 = { -2, 12 };
        private int[] button18 = { -2, 13 };
        private int[] button19 = { -2, 14 };
        private int[] button20 = { -2, 15 };

        //各種設定をXMLに保存
        public void SaveToXml()
        {
            try
            {
                //ディレクトリの作成
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                //XMLへ保存
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (FileStream fs = new FileStream(Path.Combine(directory, filename), FileMode.Create))
                {
                    serializer.Serialize(fs, this);
                }
            }
            catch
            {
            }
        }

        //各種設定をXMLから読み込む
        public static Settings LoadFromXml(string directory)
        {
            Settings settings;

            try
            {
                //既存のXMLから読み込む場合
                XmlSerializer serializer = new XmlSerializer(typeof(Settings));
                using (FileStream fs = new FileStream(Path.Combine(directory, filename), FileMode.Open))
                {
                    settings = (Settings)serializer.Deserialize(fs);
                }
            }
            catch
            {
                //新規でXMLから読み込む場合
                settings = new Settings();
            }

            settings.directory = directory;

            return settings;
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public int[] Button1
        {
            get { return button1; }
            set { button1 = value; }
        }

        public int[] Button2
        {
            get { return button2; }
            set { button2 = value; }
        }

        public int[] Button3
        {
            get { return button3; }
            set { button3 = value; }
        }

        public int[] Button4
        {
            get { return button4; }
            set { button4 = value; }
        }

        public int[] Button5
        {
            get { return button5; }
            set { button5 = value; }
        }

        public int[] Button6
        {
            get { return button6; }
            set { button6 = value; }
        }

        public int[] Button7
        {
            get { return button7; }
            set { button7 = value; }
        }

        public int[] Button8
        {
            get { return button8; }
            set { button8 = value; }
        }

        public int[] Button9
        {
            get { return button9; }
            set { button9 = value; }
        }

        public int[] Button10
        {
            get { return button10; }
            set { button10 = value; }
        }

        public int[] Button11
        {
            get { return button11; }
            set { button11 = value; }
        }

        public int[] Button12
        {
            get { return button12; }
            set { button12 = value; }
        }

        public int[] Button13
        {
            get { return button13; }
            set { button13 = value; }
        }

        public int[] Button14
        {
            get { return button14; }
            set { button14 = value; }
        }

        public int[] Button15
        {
            get { return button15; }
            set { button15 = value; }
        }

        public int[] Button16
        {
            get { return button16; }
            set { button16 = value; }
        }

        public int[] Button17
        {
            get { return button17; }
            set { button17 = value; }
        }

        public int[] Button18
        {
            get { return button18; }
            set { button18 = value; }
        }

        public int[] Button19
        {
            get { return button19; }
            set { button19 = value; }
        }

        public int[] Button20
        {
            get { return button20; }
            set { button20 = value; }
        }
    }
}
