using UnityEngine;
using System.Collections;

public class TestTakeHit : MonoBehaviour {

    public string AnimationTriggerString;

    private Animator _anim;

    private void Awake() {
        _anim = GetComponentInChildren<Animator>();
    }

    public void TakeHit() {
        _anim.SetTrigger(AnimationTriggerString);
    }

}