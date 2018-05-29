using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(TestTakeHit))]
public class TestTakeHitEditor : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        TestTakeHit myScript = (TestTakeHit)target;
        if (GUILayout.Button("Take Hit")) {
            myScript.TakeHit();
        }
    }

}