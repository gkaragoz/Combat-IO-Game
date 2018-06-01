using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRun : MonoBehaviour {

    public string animationKeyString;
    public bool isRunning = false;

    private Animator _anim;

    private void Awake() {
        _anim = GetComponentInChildren<Animator>();
    }

    public void Action() {
        isRunning = !isRunning;
        _anim.SetBool(animationKeyString, isRunning);
    }
}
