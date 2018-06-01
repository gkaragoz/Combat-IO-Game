using UnityEngine;
using System.Collections;

[RequireComponent (typeof(TakeHit), typeof(Rigidbody))]
public class TestTakeHit : MonoBehaviour {

    public string animationKeyString;

    private TakeHit _takeHit;
    private Animator _anim;
    private Rigidbody _rb;

    private void Awake() {
        _anim = GetComponentInChildren<Animator>();
        _takeHit = GetComponent<TakeHit>();
        _rb = GetComponent<Rigidbody>();
    }

    public void TakeHit() {
        _anim.SetTrigger(animationKeyString);
        _takeHit.Action(_rb, Vector3.back);
    }

}