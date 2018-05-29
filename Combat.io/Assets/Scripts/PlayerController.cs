using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 5f;  // Player base movement speed.
    public float rotationSpeed = 200f;// Player base rotation speed.

    private Transform _mesh;          // Player's character which has selected Transform object.

    private void Awake() {
        SetMesh();
    }

	void Update () {
		if (HasMesh()) {
            Move();
        }
	}

    // Player's abilities like movement, attack, die etc.
    #region Abilities
    private void Move() {
        var horizontal = Input.GetAxisRaw("Horizontal") * Time.deltaTime * rotationSpeed;
        var vertical = Input.GetAxisRaw("Vertical") * Time.deltaTime * movementSpeed;

        transform.Rotate(0, horizontal, 0);
        transform.Translate(0, 0, vertical);
    }
    #endregion

    // Init functions like find meshes, has mesh etc.
    #region Initializes
    private void SetMesh() {
        _mesh = transform.Find("Mesh").GetChild(0);
    }
    
    float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }

    private bool HasMesh() {
        return (_mesh != null) ? true : false;
    }
    #endregion
}
