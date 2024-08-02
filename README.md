# 概要
このリポジトリでは、BVE Trainsim用の入力デバイスプラグインを公開している。

# 入力デバイスプラグインとは
入力デバイスプラグインは、BVE Trainsimを操作するための外部デバイスをサポートするための拡張機能である。
入力デバイスプラグインを使用することで、BVE Trainsimでの操作をよりリアルにすることができる。

# 入力デバイスプラグイン製作環境について
## 動作環境
- BVE Trainsim 5.8のみをサポート
- OSはWindows11をサポート

## 開発環境
- Visual Studio 2022で開発<br>
- .Net Framework 3.5を使用し開発を行う<br>
  ※Visual Studioインストール時に"個別のコンポーネント"より".Net Framework 3.5"のインストールが必要

# 入力デバイスプラグインの仕様
サポートしている主幹制御器(マスコン)・ブレーキ・ボタンなどは次のとおりである。<br>
- ワンハンドルマスコン
<table id="table1" border="1">
  <tr><td>力行</td><td>5段</td></tr>
  <tr><td>ニュートラル</td><td>1段</td></tr>
  <tr><td>ブレーキ</td><td>8(常用)+1(非常)段</td></tr>
  <tr><td>レバーサー</td><td>前・中・後</td></tr>
  <tr><td>ボタン</td><td>20個</td></tr>
</table>

- ツーハンドルマスコン
<table id="table2" border="1">
  <tr><td>力行</td><td>20段</td></tr>
  <tr><td>ニュートラル</td><td>2段(マスコン・ブレーキ 各1段)</td></tr>
  <tr><td>抑速ブレーキ</td><td>20段</td></tr>
  <tr><td>ブレーキ</td><td>8(常用)+1(非常)段</td></tr>
  <tr><td>レバーサー</td><td>前・中・後</td></tr>
  <tr><td>ボタン</td><td>20個</td></tr>
</table>
<br>

次の表の制御コードを送信することで、外部デバイスによる制御を行うことができる。<br>

- ワンハンドルマスコン用制御コード
<table id="table3" border="1">
  <tr><td>制御コード</td><td>発生イベント(axis, value)</td><td>動作</td></tr>
  <tr><td>OHP01</td><td>OnLeverMoved(3, 1)</td><td>力行1段</td></tr>
  <tr><td>OHP02</td><td>OnLeverMoved(3, 2)</td><td>力行2段</td></tr>
  <tr><td>OHP03</td><td>OnLeverMoved(3, 3)</td><td>力行3段</td></tr>
  <tr><td>OHP04</td><td>OnLeverMoved(3, 4)</td><td>力行4段</td></tr>
  <tr><td>OHP05</td><td>OnLeverMoved(3, 5)</td><td>力行5段</td></tr>
  <tr><td>OHN00</td><td>OnLeverMoved(3, 0)</td><td>ニュートラル</td></tr>
  <tr><td>OHB01</td><td>OnLeverMoved(3, -1)</td><td>ブレーキ1段</td></tr>
  <tr><td>OHB02</td><td>OnLeverMoved(3, -2)</td><td>ブレーキ2段</td></tr>
  <tr><td>OHB03</td><td>OnLeverMoved(3, -3)</td><td>ブレーキ3段</td></tr>
  <tr><td>OHB04</td><td>OnLeverMoved(3, -4)</td><td>ブレーキ4段</td></tr>
  <tr><td>OHB05</td><td>OnLeverMoved(3, -5)</td><td>ブレーキ5段</td></tr>
  <tr><td>OHB06</td><td>OnLeverMoved(3, -6)</td><td>ブレーキ6段</td></tr>
  <tr><td>OHB07</td><td>OnLeverMoved(3, -7)</td><td>ブレーキ7段</td></tr>
  <tr><td>OHB08</td><td>OnLeverMoved(3, -8)</td><td>ブレーキ8段</td></tr>
  <tr><td>OHB99</td><td>OnLeverMoved(3, -99)</td><td>非常ブレーキ</td></tr>
</table>
<br>

- ツーハンドルマスコン用制御コード
<table id="table4" border="1">
  <tr><td>制御コード</td><td>発生イベント(axis, value)</td><td>動作</td></tr>
  <tr><td>THP01</td><td>OnLeverMoved(1, 1)</td><td>力行1段</td></tr>
  <tr><td>THP02</td><td>OnLeverMoved(1, 2)</td><td>力行2段</td></tr>
  <tr><td>THP03</td><td>OnLeverMoved(1, 3)</td><td>力行3段</td></tr>
  <tr><td>THP04</td><td>OnLeverMoved(1, 4)</td><td>力行4段</td></tr>
  <tr><td>THP05</td><td>OnLeverMoved(1, 5)</td><td>力行5段</td></tr>
  <tr><td>THP06</td><td>OnLeverMoved(1, 6)</td><td>力行6段</td></tr>
  <tr><td>THP07</td><td>OnLeverMoved(1, 7)</td><td>力行7段</td></tr>
  <tr><td>THP08</td><td>OnLeverMoved(1, 8)</td><td>力行8段</td></tr>
  <tr><td>THP09</td><td>OnLeverMoved(1, 9)</td><td>力行9段</td></tr>
  <tr><td>THP10</td><td>OnLeverMoved(1, 10)</td><td>力行10段</td></tr>
  <tr><td>THP11</td><td>OnLeverMoved(1, 11)</td><td>力行11段</td></tr>
  <tr><td>THP12</td><td>OnLeverMoved(1, 12)</td><td>力行12段</td></tr>
  <tr><td>THP13</td><td>OnLeverMoved(1, 13)</td><td>力行13段</td></tr>
  <tr><td>THP14</td><td>OnLeverMoved(1, 14)</td><td>力行14段</td></tr>
  <tr><td>THP15</td><td>OnLeverMoved(1, 15)</td><td>力行15段</td></tr>
  <tr><td>THP16</td><td>OnLeverMoved(1, 16)</td><td>力行16段</td></tr>
  <tr><td>THP17</td><td>OnLeverMoved(1, 17)</td><td>力行17段</td></tr>
  <tr><td>THP18</td><td>OnLeverMoved(1, 18)</td><td>力行18段</td></tr>
  <tr><td>THP19</td><td>OnLeverMoved(1, 19)</td><td>力行19段</td></tr>
  <tr><td>THP20</td><td>OnLeverMoved(1, 20)</td><td>力行20段</td></tr>
  <tr><td>THN00</td><td>OnLeverMoved(1, 0)</td><td>ニュートラル(ノッチオフ)</td></tr>
  <tr><td>THN01</td><td>OnLeverMoves(2, 0)</td><td>ニュートラル(ブレーキオフ)</td></tr>
  <tr><td>THB01</td><td>OnLeverMoved(2, 1)</td><td>ブレーキ1段</td></tr>
  <tr><td>THB02</td><td>OnLeverMoved(2, 2)</td><td>ブレーキ2段</td></tr>
  <tr><td>THB03</td><td>OnLeverMoved(2, 3)</td><td>ブレーキ3段</td></tr>
  <tr><td>THB04</td><td>OnLeverMoved(2, 4)</td><td>ブレーキ4段</td></tr>
  <tr><td>THB05</td><td>OnLeverMoved(2, 5)</td><td>ブレーキ5段</td></tr>
  <tr><td>THB06</td><td>OnLeverMoved(2, 6)</td><td>ブレーキ6段</td></tr>
  <tr><td>THB07</td><td>OnLeverMoved(2, 7)</td><td>ブレーキ7段</td></tr>
  <tr><td>THB08</td><td>OnLeverMoved(2, 8)</td><td>ブレーキ8段</td></tr>
  <tr><td>THB99</td><td>OnLeverMoved(2, 99)</td><td>非常ブレーキ</td></tr>
  <tr><td>THB51</td><td>OnLeverMoved(1, -1)</td><td>抑速ブレーキ1段</td></tr>
  <tr><td>THB52</td><td>OnLeverMoved(1, -2)</td><td>抑速ブレーキ2段</td></tr>
  <tr><td>THB53</td><td>OnLeverMoved(1, -3)</td><td>抑速ブレーキ3段</td></tr>
  <tr><td>THB54</td><td>OnLeverMoved(1, -4)</td><td>抑速ブレーキ4段</td></tr>
  <tr><td>THB55</td><td>OnLeverMoved(1, -5)</td><td>抑速ブレーキ5段</td></tr>
  <tr><td>THB56</td><td>OnLeverMoved(1, -6)</td><td>抑速ブレーキ6段</td></tr>
  <tr><td>THB57</td><td>OnLeverMoved(1, -7)</td><td>抑速ブレーキ7段</td></tr>
  <tr><td>THB58</td><td>OnLeverMoved(1, -8)</td><td>抑速ブレーキ8段</td></tr>
  <tr><td>THB59</td><td>OnLeverMoved(1, -9)</td><td>抑速ブレーキ9段</td></tr>
  <tr><td>THB60</td><td>OnLeverMoved(1, -10)</td><td>抑速ブレーキ10段</td></tr>
  <tr><td>THB61</td><td>OnLeverMoved(1, -11)</td><td>抑速ブレーキ11段</td></tr>
  <tr><td>THB62</td><td>OnLeverMoved(1, -12)</td><td>抑速ブレーキ12段</td></tr>
  <tr><td>THB63</td><td>OnLeverMoved(1, -13)</td><td>抑速ブレーキ13段</td></tr>
  <tr><td>THB64</td><td>OnLeverMoved(1, -14)</td><td>抑速ブレーキ14段</td></tr>
  <tr><td>THB65</td><td>OnLeverMoved(1, -15)</td><td>抑速ブレーキ15段</td></tr>
  <tr><td>THB66</td><td>OnLeverMoved(1, -16)</td><td>抑速ブレーキ16段</td></tr>
  <tr><td>THB67</td><td>OnLeverMoved(1, -17)</td><td>抑速ブレーキ17段</td></tr>
  <tr><td>THB68</td><td>OnLeverMoved(1, -18)</td><td>抑速ブレーキ18段</td></tr>
  <tr><td>THB69</td><td>OnLeverMoved(1, -19)</td><td>抑速ブレーキ19段</td></tr>
  <tr><td>THB70</td><td>OnLeverMoved(1, -20)</td><td>抑速ブレーキ20段</td></tr>
</table>
<br>

- 共通制御コード
<table id="table5" border="1">
  <tr><td>制御コード</td><td>発生イベント(axis, value)</td><td>動作</td></tr>
  <tr><td>LEV0F</td><td>OnLeverMoved(0, 1)</td><td>レバーサー 前</td></tr>
  <tr><td>LEV0C</td><td>OnLeverMoved(0, 0)</td><td>レバーサー 中</td></tr>
  <tr><td>LEV0B</td><td>OnLeverMoved(0, -1)</td><td>レバーサー 後</td></tr>
  <tr><td>BTP01</td><td>OnKeyDown(-1, 0)</td><td>ボタン1 ON</td></tr>
  <tr><td>BTR01</td><td>OnKeyUp(-1, 0)</td><td>ボタン1 OFF</td></tr>
  <tr><td>BTP02</td><td>OnKeyDown(-1, 1)</td><td>ボタン2 ON</td></tr>
  <tr><td>BTR02</td><td>OnKeyUp(-1, 1)</td><td>ボタン2 OFF</td></tr>
  <tr><td>BTP03</td><td>OnKeyDown(-1, 2)</td><td>ボタン3 ON</td></tr>
  <tr><td>BTR03</td><td>OnKeyUp(-1, 2)</td><td>ボタン3 OFF</td></tr>
  <tr><td>BTP04</td><td>OnKeyDown(-1, 3)</td><td>ボタン4 ON</td></tr>
  <tr><td>BTR04</td><td>OnKeyUp(-1, 3)</td><td>ボタン4 OFF</td></tr>
  <tr><td>BTP05</td><td>OnKeyDown(-2, 0)</td><td>ボタン5 ON</td></tr>
  <tr><td>BTR05</td><td>OnKeyUp(-2, 0)</td><td>ボタン5 OFF</td></tr>
  <tr><td>BTP06</td><td>OnKeyDown(-2, 1)</td><td>ボタン6 ON</td></tr>
  <tr><td>BTR06</td><td>OnKeyUp(-2, 1)</td><td>ボタン6 OFF</td></tr>
  <tr><td>BTP07</td><td>OnKeyDown(-2, 2)</td><td>ボタン7 ON</td></tr>
  <tr><td>BTR07</td><td>OnKeyUp(-2, 2)</td><td>ボタン7 OFF</td></tr>
  <tr><td>BTP08</td><td>OnKeyDown(-2, 3)</td><td>ボタン8 ON</td></tr>
  <tr><td>BTR08</td><td>OnKeyUp(-2, 3)</td><td>ボタン8 OFF</td></tr>
  <tr><td>BTP09</td><td>OnKeyDown(-2, 4)</td><td>ボタン9 ON</td></tr>
  <tr><td>BTR09</td><td>OnKeyUp(-2, 4)</td><td>ボタン9 OFF</td></tr>
  <tr><td>BTP10</td><td>OnKeyDown(-2, 5)</td><td>ボタン10 ON</td></tr>
  <tr><td>BTR10</td><td>OnKeyUp(-2, 5)</td><td>ボタン10 OFF</td></tr>
  <tr><td>BTP11</td><td>OnKeyDown(-2, 6)</td><td>ボタン11 ON</td></tr>
  <tr><td>BTR11</td><td>OnKeyUp(-2, 6)</td><td>ボタン11 OFF</td></tr>
  <tr><td>BTP12</td><td>OnKeyDown(-2, 7)</td><td>ボタン12 ON</td></tr>
  <tr><td>BTR12</td><td>OnKeyUp(-2, 7)</td><td>ボタン12 OFF</td></tr>
  <tr><td>BTP13</td><td>OnKeyDown(-2, 8)</td><td>ボタン13 ON</td></tr>
  <tr><td>BTR13</td><td>OnKeyUp(-2, 8)</td><td>ボタン13 OFF</td></tr>
  <tr><td>BTP14</td><td>OnKeyDown(-2, 9)</td><td>ボタン14 ON</td></tr>
  <tr><td>BTR14</td><td>OnKeyUp(-2, 9)</td><td>ボタン14 OFF</td></tr>
  <tr><td>BTP15</td><td>OnKeyDown(-2, 10)</td><td>ボタン15 ON</td></tr>
  <tr><td>BTR15</td><td>OnKeyUp(-2, 10)</td><td>ボタン15 OFF</td></tr>
  <tr><td>BTP16</td><td>OnKeyDown(-2, 11)</td><td>ボタン16 ON</td></tr>
  <tr><td>BTR16</td><td>OnKeyUp(-2, 11)</td><td>ボタン16 OFF</td></tr>
  <tr><td>BTP17</td><td>OnKeyDown(-2, 12)</td><td>ボタン17 ON</td></tr>
  <tr><td>BTR17</td><td>OnKeyUp(-2, 12)</td><td>ボタン17 OFF</td></tr>
  <tr><td>BTP18</td><td>OnKeyDown(-2, 13)</td><td>ボタン18 ON</td></tr>
  <tr><td>BTR18</td><td>OnKeyUp(-2, 13)</td><td>ボタン18 OFF</td></tr>
  <tr><td>BTP19</td><td>OnKeyDown(-2, 14)</td><td>ボタン19 ON</td></tr>
  <tr><td>BTR19</td><td>OnKeyUp(-2, 14)</td><td>ボタン19 OFF</td></tr>
  <tr><td>BTP20</td><td>OnKeyDown(-2, 15)</td><td>ボタン20 ON</td></tr>
  <tr><td>BTR20</td><td>OnKeyUp(-2, 15)</td><td>ボタン20 OFF</td></tr>
</table>
※発生イベント・動作は設定によって変更することができる。<br>
※ボタンの”発生イベント”はデフォルトの値を表記している。<br><br>

# 入力デバイスプラグイン導入方法
① ディレクトリ```C:\Program Files (x86)\mackoy\BveTs5\Input Devices```に入力デバイスプラグインのDLLファイル```SerialDevicePlugin.dll```を追加する。<br>
② "設定"→"入力デバイス"→"□"を"☑"にする。<br>
③ 必要に応じて、キーの割り当てを行う。

# 注意事項
このリポジトリにあるデータについて、原則下記の行為を禁じる。
- 許可なく入力デバイスプラグインのデータを改変
- 入力デバイスプラグインの二次配布
- 各種イベント（文化祭や運転体験会など）で入力デバイスプラグインの使用

# 免責事項
このプログラムの使用は、利用者の責任において行われるものである。<br>
本プログラムの利用に起因するいかなる損害についても、当方は一切の責任を負わない。<br>
プログラムに関するすべてのリスクは、利用者が負うものである。<br>
