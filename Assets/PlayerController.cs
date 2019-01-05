using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private void FixedUpdate()
    {
        // get user input into x and z
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // get current Rigidbody component
        Rigidbody rigidbody = GetComponent<Rigidbody>();

        // add force x/z axis
        rigidbody.AddForce(x, 0, z);
    }
}
