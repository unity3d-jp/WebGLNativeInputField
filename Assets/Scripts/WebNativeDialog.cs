using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class WebNativeDialog {
    [DllImport("__Internal")]
    private static extern string NativeDialogPrompt(string title, string defaultValue);

    /// <summary>
    /// ネイティブの文字列入力のダイアログを出します
    /// </summary>
    /// <param name="title">ダイアログタイトル名</param>
    /// <param name="defaultValue">デフォルト値</param>
    /// <returns></returns>
    public static string OpenNativeStringDialog(string title, string defaultValue)
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        return NativeDialogPrompt(title, defaultValue);
#else
        return defaultValue;
#endif
    }
}
