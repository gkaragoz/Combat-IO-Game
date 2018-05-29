using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 5f;  // Player base movement speed.
    public float rotationSpeed = 200f;// Player base rotation speed.

    private Rigidbody _rb;            // Player's rigidbody.
    private Transform _mesh;          // Player's character which has selected Transform object.

    private void Awake() {
        SetMesh();
        SetRigidbody();
    }

	void Update () {
		if (HasMesh()) {
            Move();
            Rotate();
        }
	}

    // Player's abilities like movement, attack, die etc.
    #region Abilities
    private void Move() {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        _rb.velocity = new Vector3(horizontal, 0, vertical) * movementSpeed;
    }

    private void Rotate() {
        int direction = 0;
        if (Input.GetKey(KeyCode.Q))
            direction = -1;
        if (Input.GetKey(KeyCode.E))
            direction = 1;

        transform.Rotate(0, direction * Time.deltaTime * rotationSpeed, 0);
    }
    #endregion

    // Init functions like find rigidbody, meshes, has mesh etc.
    #region Initializes
    private void SetRigidbody() {
        _rb = GetComponent<Rigidbody>();
    }

    private void SetMesh() {
        _mesh = transform.Find("Mesh").GetChild(0);
    }

    private bool HasMesh() {
        return (_mesh != null) ? true : false;
    }
    #endregion
}
