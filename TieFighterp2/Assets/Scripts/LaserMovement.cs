using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    private float speed;
    public Rigidbody rigidBody;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        speed = 50f;
    }
    private void Update()
    { //send laser forward
        rigidBody.velocity = Vector3.left * speed;
    }
}
