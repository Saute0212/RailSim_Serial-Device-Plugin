using Mackoy.Bvets;
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialDevicePlugin
{
    //"Mackoy.Bvets.IInputDevice"のクラスを継承
    public class SerialDevicePlugin : Mackoy.Bvets.IInputDevice
    {
        public event InputEventHandler KeyDown; //キーが押されたときのイベント
        public event InputEventHandler KeyUp; //キーを離したときのイベント
        public event InputEventHandler LeverMoved; //ハンドルを操作したときのイベント

        //プラグインが読み込まれたときに実行
        public void Load(string SettingsXmlPath)
        {

        }

        //プラグイン・シナリオが読み込まれたときに実行
        public void SetAxisRanges(int[][] ranges)
        {

        }

        //毎フレーム実行
        public void Tick()
        {

        }

        //プラグインの設定画面を表示
        public void Configure(IWin32Window owner)
        {

        }

        //BVEの終了時に実行
        public void Dispose()
        {

        }

        //COMポートを開く
        private void openPort()
        {

        }

        //COMポートを閉じる
        private void closePort()
        {

        }

        //ハンドルを操作したときに実行：LeverMovedイベント
        private void onLeverMoved(int axis, int notch)
        {

        }

        //キーを押したときに実行：KeyDownイベント
        private void onKeyDown(int axis, int keyCode)
        {

        }

        //キーを離したときに実行：KeyUpイベント
        private void onKeyUp(int axis, int keyCode)
        {

        }
    }
}
