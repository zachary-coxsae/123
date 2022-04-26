using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public float speed = 10f;
    protected Rigidbody2D _rigidbody;
    private Vector2 _direction;
    private Vector3 _rotation;
    public float VerticalLimit;

    //Calls upon the rigid body on startup
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    //player movement
    private void Update()
    {
        //lateral player movement
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        //tilt fling bound to Q and E 
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.eulerAngles = new Vector3 (0, 0, 150);
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            transform.eulerAngles = new Vector3(0, 0, -150);
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        // if there is no input the player character stops
        else
        {
            _direction = Vector2.zero;
            _rotation = new Vector3 (0, 0 ,0);
        }
        //if (transform.position.y < VerticalLimit)
       // {
       //    transform.position = new Vector2(transform.position.x, VerticalLimit);
       // }
    }
    private void FixedUpdate()
    {
        //gives the object speed
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * this.speed);
        }
    }

}
