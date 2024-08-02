using Mackoy.Bvets;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialDevicePlugin
{
    //"Mackoy.Bvets.IInputDevice"のクラスを継承
    public class SerialDevicePlugin : Mackoy.Bvets.IInputDevice
    {
        public SerialPort SelectedPort = null; //選択したCOMポート
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
                OpenPort();
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
                switch(words[i])
                {
                    //共通制御コード：レバーサー
                    case "LEV0F":
                        OnLeverMoved(0, 1);
                        break;
                    case "LEV0C":
                        OnLeverMoved(0, 0);
                        break;
                    case "LEV0B":
                        OnLeverMoved(0, -1);
                        break;

                    //共通制御コード：ボタン
                    case "BTP01":
                        OnKeyDown(settings.Button1[0], settings.Button1[1]);
                        break;
                    case "BTR01":
                        OnKeyUp(settings.Button1[0], settings.Button1[1]);
                        break;
                    case "BTP02":
                        OnKeyDown(settings.Button2[0], settings.Button2[1]);
                        break;
                    case "BTR02":
                        OnKeyUp(settings.Button2[0], settings.Button2[1]);
                        break;
                    case "BTP03":
                        OnKeyDown(settings.Button3[0], settings.Button3[1]);
                        break;
                    case "BTR03":
                        OnKeyUp(settings.Button3[0], settings.Button3[1]);
                        break;
                    case "BTP04":
                        OnKeyDown(settings.Button4[0], settings.Button4[1]);
                        break;
                    case "BTR04":
                        OnKeyUp(settings.Button4[0], settings.Button4[1]);
                        break;
                    case "BTP05":
                        OnKeyDown(settings.Button5[0], settings.Button5[1]);
                        break;
                    case "BTR05":
                        OnKeyUp(settings.Button5[0], settings.Button5[1]);
                        break;
                    case "BTP06":
                        OnKeyDown(settings.Button6[0], settings.Button6[1]);
                        break;
                    case "BTR06":
                        OnKeyUp(settings.Button6[0], settings.Button6[1]);
                        break;
                    case "BTP07":
                        OnKeyDown(settings.Button7[0], settings.Button7[1]);
                        break;
                    case "BTR07":
                        OnKeyUp(settings.Button7[0], settings.Button7[1]);
                        break;
                    case "BTP08":
                        OnKeyDown(settings.Button8[0], settings.Button8[1]);
                        break;
                    case "BTR08":
                        OnKeyUp(settings.Button8[0], settings.Button8[1]);
                        break;
                    case "BTP09":
                        OnKeyDown(settings.Button9[0], settings.Button9[1]);
                        break;
                    case "BTR09":
                        OnKeyUp(settings.Button9[0], settings.Button9[1]);
                        break;
                    case "BTP10":
                        OnKeyDown(settings.Button10[0], settings.Button10[1]);
                        break;
                    case "BTR10":
                        OnKeyUp(settings.Button10[0], settings.Button10[1]);
                        break;
                    case "BTP11":
                        OnKeyDown(settings.Button11[0], settings.Button11[1]);
                        break;
                    case "BTR11":
                        OnKeyUp(settings.Button11[0], settings.Button11[1]);
                        break;
                    case "BTP12":
                        OnKeyDown(settings.Button12[0], settings.Button12[1]);
                        break;
                    case "BTR12":
                        OnKeyUp(settings.Button12[0], settings.Button12[1]);
                        break;
                    case "BTP13":
                        OnKeyDown(settings.Button13[0], settings.Button13[1]);
                        break;
                    case "BTR13":
                        OnKeyUp(settings.Button13[0], settings.Button13[1]);
                        break;
                    case "BTP14":
                        OnKeyDown(settings.Button14[0], settings.Button14[1]);
                        break;
                    case "BTR14":
                        OnKeyUp(settings.Button14[0], settings.Button14[1]);
                        break;
                    case "BTP15":
                        OnKeyDown(settings.Button15[0], settings.Button15[1]);
                        break;
                    case "BTR15":
                        OnKeyUp(settings.Button15[0], settings.Button15[1]);
                        break;
                    case "BTP16":
                        OnKeyDown(settings.Button16[0], settings.Button16[1]);
                        break;
                    case "BTR16":
                        OnKeyUp(settings.Button16[0], settings.Button16[1]);
                        break;
                    case "BTP17":
                        OnKeyDown(settings.Button17[0], settings.Button17[1]);
                        break;
                    case "BTR17":
                        OnKeyUp(settings.Button17[0], settings.Button17[1]);
                        break;
                    case "BTP18":
                        OnKeyDown(settings.Button18[0], settings.Button18[1]);
                        break;
                    case "BTR18":
                        OnKeyUp(settings.Button18[0], settings.Button18[1]);
                        break;
                    case "BTP19":
                        OnKeyDown(settings.Button19[0], settings.Button19[1]);
                        break;
                    case "BTR19":
                        OnKeyUp(settings.Button19[0], settings.Button19[1]);
                        break;
                    case "BTP20":
                        OnKeyDown(settings.Button20[0], settings.Button20[1]);
                        break;
                    case "BTR20":
                        OnKeyUp(settings.Button20[0], settings.Button20[1]);
                        break;

                    //ワンハンドルマスコン：力行
                    case "OHP01":
                        OnLeverMoved(3, 1);
                        break;
                    case "OHP02":
                        OnLeverMoved(3, 2);
                        break;
                    case "OHP03":
                        OnLeverMoved(3, 3);
                        break;
                    case "OHP04":
                        OnLeverMoved(3, 4);
                        break;
                    case "OHP05":
                        OnLeverMoved(3, 5);
                        break;

                    //ワンハンドルマスコン：ニューラル
                    case "OHN00":
                        OnLeverMoved(3, 0);
                        break;

                    //ワンハンドルマスコン：ブレーキ
                    case "OHB01":
                        OnLeverMoved(3, -1);
                        break;
                    case "OHB02":
                        OnLeverMoved(3, -2);
                        break;
                    case "OHB03":
                        OnLeverMoved(3, -3);
                        break;
                    case "OHB04":
                        OnLeverMoved(3, -4);
                        break;
                    case "OHB05":
                        OnLeverMoved(3, -5);
                        break;
                    case "OHB06":
                        OnLeverMoved(3, -6);
                        break;
                    case "OHB07":
                        OnLeverMoved(3, -7);
                        break;
                    case "OHB08":
                        OnLeverMoved(3, -8);
                        break;
                    case "OHB99":
                        OnLeverMoved(3, -99);
                        break;

                    //ツーハンドルマスコン：力行
                    case "THP01":
                        OnLeverMoved(1, 1);
                        break;
                    case "THP02":
                        OnLeverMoved(1, 2);
                        break;
                    case "THP03":
                        OnLeverMoved(1, 3);
                        break;
                    case "THP04":
                        OnLeverMoved(1, 4);
                        break;
                    case "THP05":
                        OnLeverMoved(1, 5);
                        break;
                    case "THP06":
                        OnLeverMoved(1, 6);
                        break;
                    case "THP07":
                        OnLeverMoved(1, 7);
                        break;
                    case "THP08":
                        OnLeverMoved(1, 8);
                        break;
                    case "THP09":
                        OnLeverMoved(1, 9);
                        break;
                    case "THP10":
                        OnLeverMoved(1, 10);
                        break;
                    case "THP11":
                        OnLeverMoved(1, 11);
                        break;
                    case "THP12":
                        OnLeverMoved(1, 12);
                        break;
                    case "THP13":
                        OnLeverMoved(1, 13);
                        break;
                    case "THP14":
                        OnLeverMoved(1, 14);
                        break;
                    case "THP15":
                        OnLeverMoved(1, 15);
                        break;
                    case "THP16":
                        OnLeverMoved(1, 16);
                        break;
                    case "THP17":
                        OnLeverMoved(1, 17);
                        break;
                    case "THP18":
                        OnLeverMoved(1, 18);
                        break;
                    case "THP19":
                        OnLeverMoved(1, 19);
                        break;
                    case "THP20":
                        OnLeverMoved(1, 20);
                        break;

                    //ツーハンドルマスコン：ニューラル
                    case "THN00":
                        OnLeverMoved(1, 0);
                        break;
                    case "THN01":
                        OnLeverMoved(2, 0);
                        break;

                    //ツーハンドルマスコン：ブレーキ
                    case "THB01":
                        OnLeverMoved(2, 1);
                        break;
                    case "THB02":
                        OnLeverMoved(2, 2);
                        break;
                    case "THB03":
                        OnLeverMoved(2, 3);
                        break;
                    case "THB04":
                        OnLeverMoved(2, 4);
                        break;
                    case "THB05":
                        OnLeverMoved(2, 5);
                        break;
                    case "THB06":
                        OnLeverMoved(2, 6);
                        break;
                    case "THB07":
                        OnLeverMoved(2, 7);
                        break;
                    case "THB08":
                        OnLeverMoved(2, 8);
                        break;
                    case "THB99":
                        OnLeverMoved(2, 99);
                        break;

                    //ツーハンドルマスコン：抑速ブレーキ
                    case "THB51":
                        OnLeverMoved(1, -1);
                        break;
                    case "THB52":
                        OnLeverMoved(1, -2);
                        break;
                    case "THB53":
                        OnLeverMoved(1, -3);
                        break;
                    case "THB54":
                        OnLeverMoved(1, -4);
                        break;
                    case "THB55":
                        OnLeverMoved(1, -5);
                        break;
                    case "THB56":
                        OnLeverMoved(1, -6);
                        break;
                    case "THB57":
                        OnLeverMoved(1, -7);
                        break;
                    case "THB58":
                        OnLeverMoved(1, -8);
                        break;
                    case "THB59":
                        OnLeverMoved(1, -9);
                        break;
                    case "THB60":
                        OnLeverMoved(1, -10);
                        break;
                    case "THB61":
                        OnLeverMoved(1, -11);
                        break;
                    case "THB62":
                        OnLeverMoved(1, -12);
                        break;
                    case "THB63":
                        OnLeverMoved(1, -13);
                        break;
                    case "THB64":
                        OnLeverMoved(1, -14);
                        break;
                    case "THB65":
                        OnLeverMoved(1, -15);
                        break;
                    case "THB66":
                        OnLeverMoved(1, -16);
                        break;
                    case "THB67":
                        OnLeverMoved(1, -17);
                        break;
                    case "THB68":
                        OnLeverMoved(1, -18);
                        break;
                    case "THB69":
                        OnLeverMoved(1, -19);
                        break;
                    case "THB70":
                        OnLeverMoved(1, -20);
                        break;
                }
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
                SelectedPort = new SerialPort(settings.Port, settings.Speed, Parity.None, 8, StopBits.One);
                SelectedPort.Open();
                SelectedPort.Write("SerialDevicePlugin\n");
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
