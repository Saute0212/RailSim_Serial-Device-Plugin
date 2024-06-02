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

        private int port = 0;
        private int speed = 0;

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
    }
}
