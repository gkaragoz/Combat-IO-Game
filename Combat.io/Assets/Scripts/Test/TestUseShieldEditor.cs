using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestUseShield))]
public class TestUseShieldEditor : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        TestUseShield myScript = (TestUseShield)target;
        if (GUILayout.Button("Use Shield")) {
            myScript.Action();
        }
    }
}
