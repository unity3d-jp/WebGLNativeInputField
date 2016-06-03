# WebGLNativeInputField
## in English
Using this , you can use IME on Unity WebGL content.<br />
You can do "copy&paste" or input some characters which depends on IME.<br />
<br />
How to Use<br />
Replace "UnityEngine.UI.InputFiled" to "WebGLNativeInputField" which I made.<br />
![alt text](doc/HowToUse1.png) <br />
<br />
We prepared two method.<br />
You can choose which one on Inspector.<br />
![alt text](doc/HowToUse2.png)<br />
<br />
1.Popup dialog which is created by "window.prompt".<br />
![alt text](doc/HowToUse3.png)
<br />

2.Overlay html which is created by javascript dynamically.<br />
![alt text](doc/HowToUse4.png)
<br />

Demo is follow.<br />
https://unity3d-jp.github.io/WebGLNativeInputField/ <br />

Demo is working like this.
![alt text](doc/DemoExplanation.png)

##日本語説明
UnityのWebGLで日本語入力を可能にします。<br />
<br />
使い方<br />
InputFieldの代わりに、こちらで用意しました「WebGLNativeInputField」を利用下さい。<br />
WEBGLで実行したときにのみNativeのインプットを利用するようになっています。<br />
![alt text](doc/HowToUse1.png) <br />
<br />
ダイアログの方式は下記の二種類用意しました。<br />
どちらを使うかなどの設定はInspector上で出来ます。<br />
![alt text](doc/HowToUse2.png)<br />
<br />
1.JavaScriptからポップアップダイアログを出して入力する方式<br />
![alt text](doc/HowToUse3.png)<br />
<br />
2.HTMLを動的に生成して、ゲーム画面の上に入力フォームを呼び出す形式<br />
![alt text](doc/HowToUse4.png)<br />
<br />

実行デモは下記になります<br />
https://unity3d-jp.github.io/WebGLNativeInputField/ <br />

このように動きます
![alt text](doc/DemoExplanation.png)
