using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeHit : MonoBehaviour {

    public float power = 1000f;

    public void Action(Rigidbody rb, Vector3 hitPoint) {
        rb.AddForce(hitPoint * power);
    }
}
