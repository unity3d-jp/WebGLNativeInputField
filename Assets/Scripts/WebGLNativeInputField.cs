using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WebGLNativeInputField : UnityEngine.UI.InputField
{
    public string dialogTitle = "Input Text";

#if UNITY_WEBGL && !UNITY_EDITOR

    public override void OnSelect(BaseEventData eventData)
    {
        this.text = WebNativeDialog.OpenNativeStringDialog(dialogTitle, this.text);
        StartCoroutine(this.DelayInputDeactive());
    }
    private IEnumerator DelayInputDeactive()
    {
        yield return new WaitForEndOfFrame();
        this.DeactivateInputField();
        EventSystem.current.SetSelectedGameObject(null);
    }
    
#endif
}
