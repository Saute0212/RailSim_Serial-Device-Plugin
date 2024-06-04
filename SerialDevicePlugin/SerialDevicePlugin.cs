using Mackoy.Bvets;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialDevicePlugin
{
    //"Mackoy.Bvets.IInputDevice"のクラスを継承
    public class SerialDevicePlugin : Mackoy.Bvets.IInputDevice
    {
        private SerialPort SelectedPort = null; //選択したCOMポート
        private string lastWord = string.Empty;

        public static Settings settings = null;

        public event InputEventHandler KeyDown; //キーが押されたときのイベント
        public event InputEventHandler KeyUp; //キーを離したときのイベント
        public event InputEventHandler LeverMoved; //ハンドルを操作したときのイベント

        //プラグインが読み込まれたときに実行
        public void Load(string SettingsXmlPath)
        {
            settings = Settings.LoadFromXml(SettingsXmlPath);

            OpenPort();

            if (SelectedPort != null)
            {
                try
                {
                    SelectedPort.Write("SerialDevicePlugin\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //プラグイン・シナリオが読み込まれたときに実行
        public void SetAxisRanges(int[][] ranges)
        {
        }

        //毎フレーム実行
        public void Tick()
        {
            if(SelectedPort == null)
            {
                return;
            }

            string text;
            try
            {
                text = SelectedPort.ReadExisting();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosePort();
                return;
            }

            if(text.Length == 0)
            {
                return;
            }

            //制御コードに応じてイベント発生
            string[] words = (lastWord + text).Split('\r');
            for(int i = 0; i < words.Length -1; i++)
            {

            }

            lastWord = words[words.Length - 1];
        }

        //プラグインの設定画面を表示
        public void Configure(IWin32Window owner)
        {
            using (FormConfig form = new FormConfig())
            {
                form.ShowDialog(owner);
            }
        }

        //BVEの終了時に実行
        public void Dispose()
        {
            ClosePort();

            if(settings != null)
            {
                settings.SaveToXml();
                settings = null;
            }
        }

        //COMポートを開く
        private void OpenPort()
        {
            try
            {
                SelectedPort = new SerialPort("COM" + settings.Port.ToString(), settings.Speed, Parity.None, 8, StopBits.One);
                SelectedPort.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Serial Device Plugin -ERROR-", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClosePort();
            }
        }

        //COMポートを閉じる
        private void ClosePort()
        {
            if(SelectedPort != null)
            {
                try
                {
                    SelectedPort.Close();
                }
                catch
                {
                }

                SelectedPort = null;
            }
        }

        //ハンドルを操作したときに実行：LeverMovedイベント
        private void OnLeverMoved(int axis, int notch)
        {
            if(LeverMoved != null)
            {
                LeverMoved(this, new InputEventArgs(axis, notch));
            }
        }

        //キーを押したときに実行：KeyDownイベント
        private void OnKeyDown(int axis, int keyCode)
        {
            if(LeverMoved != null)
            {
                KeyDown(this, new InputEventArgs(axis, keyCode));
            }
        }

        //キーを離したときに実行：KeyUpイベント
        private void OnKeyUp(int axis, int keyCode)
        {
            if(LeverMoved != null)
            {
                KeyUp(this, new InputEventArgs(axis, keyCode));
            }
        }
    }
}
