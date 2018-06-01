using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestRun))]
public class TestRunEditor : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        TestRun myScript = (TestRun)target;
        if (GUILayout.Button("Play/Stop Run")) {
            myScript.Action();
        }
    }
}
