using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 5f;  // Player base movement speed.

    private Transform _mesh;          // Player's character which has selected Transform object.

    private void Awake() {
        FindMesh();
    }

	void Update () {
		if (HasMesh()) {
            Move();
        }
	}

    // Player's abilities like movement, attack, die etc.
    #region Abilities
    private void Move() {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical);
        transform.Translate(direction * movementSpeed * Time.deltaTime);
    }
    #endregion

    // Init functions like find meshes, has mesh etc.
    #region Initializes
    private void FindMesh() {
        _mesh = transform.Find("Mesh").GetChild(0);
    }

    private bool HasMesh() {
        return (_mesh != null) ? true : false;
    }
    #endregion
}
