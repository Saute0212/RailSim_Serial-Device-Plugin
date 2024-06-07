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
サポートしている主幹制御器(マスコン)・ボタンなどは次のとおりである。<br>
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
  <tr><td>ニュートラル</td><td>1段</td></tr>
  <tr><td>抑速ブレーキ</td><td>20段</td></tr>
  <tr><td>ブレーキ</td><td>8(常用)+1(非常)段</td></tr>
  <tr><td>レバーサー</td><td>前・中・後</td></tr>
  <tr><td>ボタン</td><td>20個</td></tr>
</table>
<br>

次の表の制御コードを送信することで、外部デバイスによる制御を行うことができる。<br>
<table id="table3" border="1">
  <tr><td>制御コード</td><td>発生イベント(axis, value)</td><td>動作</td></tr>
  <tr><td></td><td></td><td></td></tr>
  <tr><td></td><td></td><td></td></tr>
  <tr><td></td><td></td><td></td></tr>
</table>

# 入力デバイスプラグイン導入方法
① ディレクトリ```C:\Program Files (x86)\mackoy\BveTs5\Input Devices```に入力デバイスプラグインのDLLファイルを追加する。<br>
② "設定"→"入力デバイス"→"□"を"☑"にする。<br>
③ 必要に応じて、キーの割り当てを行う。

# 注意事項
このリポジトリにあるデータについて、原則下記の行為を禁じる
- 許可なく入力デバイスプラグインのデータを改変
- 入力デバイスプラグインの二次配布
- 各種イベント（文化祭や運転体験会など）で入力デバイスプラグインの使用
