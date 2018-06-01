using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMeleeAttack : MonoBehaviour {

    public string animationKeyString;

    private Animator _anim;

    private void Awake() {
        _anim = GetComponentInChildren<Animator>();
    }

    public void Action() {
        _anim.SetTrigger(animationKeyString);
    }
}
