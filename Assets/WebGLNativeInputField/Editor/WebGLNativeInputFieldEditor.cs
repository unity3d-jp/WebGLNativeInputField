using UnityEngine;
using UnityEditor;
using UnityEditor.UI;

[CustomEditor( typeof(WebGLNativeInputField))]
public class WebGLNativeInputFieldEditor : InputFieldEditor
{
    private SerializedProperty m_DialogTitle;

    protected override void OnEnable()
    {
        base.OnEnable();
        m_DialogTitle = serializedObject.FindProperty("m_DialogTitle");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.PropertyField(m_DialogTitle);
        serializedObject.ApplyModifiedProperties();
        base.OnInspectorGUI();
    }
}
