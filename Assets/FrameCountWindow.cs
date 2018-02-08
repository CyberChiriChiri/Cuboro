#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;

public class FrameCountWindow : EditorWindow
{
    [MenuItem("Window/FrameCountWindow")]
    public static void OpenWindow()
    {
        GetWindow<FrameCountWindow>();
    }

    void OnGUI()
    {
        EditorGUILayout.LabelField("Frame: " + Time.frameCount);
    }

    // 毎フレーム更新
    void Update()
    {
        Repaint();
    }
}
#endif