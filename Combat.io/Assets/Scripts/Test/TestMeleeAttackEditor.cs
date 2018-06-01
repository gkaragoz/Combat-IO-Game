using System.Collections;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TestMeleeAttack))]
public class TestMeleeAttackEditor : Editor {

    public override void OnInspectorGUI() {
        DrawDefaultInspector();

        TestMeleeAttack myScript = (TestMeleeAttack)target;
        if (GUILayout.Button("Play/Stop Run")) {
            myScript.Action();
        }
    }
}
