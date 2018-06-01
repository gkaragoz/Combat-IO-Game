using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUseShield : MonoBehaviour {

    public string animationKeyString;
    public bool isUsingShield = false;

    private Animator _anim;

    private void Awake() {
        _anim = GetComponentInChildren<Animator>();
    }

    public void Action() {
        isUsingShield = !isUsingShield;
        _anim.SetBool(animationKeyString, isUsingShield);
    }
}