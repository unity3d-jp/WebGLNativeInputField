# WebGLNativeInputField
## in English
Using this , you can use IME on Unity WebGL content.<br />
You can do "copy&paste" or input some characters which depends on IME.<br />
<br />
This system calls "window.prompt" which is javascript native function.<br />
<br />
How to Use<br />
Replace "UnityEngine.UI.InputFiled" to "WebGLNativeInputField" which I made.<br />]

Demo is follow.
https://unity3d-jp.github.io/WebGLNativeInputField/ <br />
Lower Field is "InputField" which is Unity standard UI System.
Upper Field is "WebGLNativeInputField" which I made.

##日本語説明
UnityのWebGLで日本語入力を可能にします。<br />
Javascriptのwindow.promptを呼び出すことによって実現しております。<br />
<br />
使い方<br />
InputFieldの代わりに、こちらで用意しました「WebGLNativeInputField」を利用下さい。<br />
WEBGLで実行したときにのみNativeのインプットを利用するようになっています。<br />
(ご利用はWebNativeInputFile.csだけでなく、Plugins以下もコピーして利用して下さい。<br />
<br />
入力中はゲームの処理がブロックされるので、オンラインゲームのチャットのような用途ではご利用できないかもしれませんが、多くのケースでは役に立つと思い用意しました。


実行デモは下記になります<br />
https://unity3d-jp.github.io/WebGLNativeInputField/ <br />
通常のInputFieldと今回用意したカスタムのInputFiledの違いをご確認ください
