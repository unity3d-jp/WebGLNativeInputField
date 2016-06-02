using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WebGLNativeInputField : UnityEngine.UI.InputField
{
    public string m_DialogTitle = "Input Text";

#if UNITY_WEBGL && !UNITY_EDITOR

    public override void OnSelect(BaseEventData eventData)
    {
        this.text = WebNativeDialog.OpenNativeStringDialog(m_DialogTitle, this.text);
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
