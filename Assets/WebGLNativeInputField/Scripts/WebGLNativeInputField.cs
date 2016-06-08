using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WebGLNativeInputField : UnityEngine.UI.InputField
{
    public enum EDialogType
    {
        PromptPopup,
        OverlayHtml,
    }
    public string m_DialogTitle = "Input Text";
    public string m_DialogOkBtn = "OK";
    public string m_DialogCancelBtn = "Cancel";
    public EDialogType m_DialogType = EDialogType.OverlayHtml;

#if UNITY_WEBGL && !UNITY_EDITOR 

    public override void OnSelect(BaseEventData eventData)
    {
        switch( m_DialogType ){
            case EDialogType.PromptPopup:
                this.text = WebNativeDialog.OpenNativeStringDialog(m_DialogTitle, this.text);
                StartCoroutine(this.DelayInputDeactive());
                break;
            case EDialogType.OverlayHtml:
                WebNativeDialog.SetUpOverlayDialog(m_DialogTitle, this.text , m_DialogOkBtn , m_DialogCancelBtn );
                StartCoroutine(this.OverlayHtmlCoroutine());
                break;
        }
    }
    private IEnumerator DelayInputDeactive()
    {
        yield return new WaitForEndOfFrame();
        this.DeactivateInputField();
        EventSystem.current.SetSelectedGameObject(null);
    }

    private IEnumerator OverlayHtmlCoroutine()
    {
        yield return new WaitForEndOfFrame();
        this.DeactivateInputField();
        EventSystem.current.SetSelectedGameObject(null);
        WebGLInput.captureAllKeyboardInput = false;
        while (WebNativeDialog.IsOverlayDialogActive())
        {
            yield return null;
        }
        WebGLInput.captureAllKeyboardInput = true;

        if (!WebNativeDialog.IsOverlayDialogCanceled())
        {
            this.text = WebNativeDialog.GetOverlayDialogValue();
        }
    }
    
#endif
}
