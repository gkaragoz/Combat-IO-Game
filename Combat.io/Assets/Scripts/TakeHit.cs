using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeHit : MonoBehaviour {

    public void Action(Rigidbody rb, Vector3 hitPoint) {
        rb.AddForce(-1 * hitPoint * 100f);
    }
}
