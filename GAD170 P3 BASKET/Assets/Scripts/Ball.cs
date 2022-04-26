using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 200f;
    public int damage = 1;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    //sends the ball in a random direction when the game starts
    private void Start()
    {
        ResetPosition();
    }
    //creating a ResetPosition function to reset the ball after a score has occured
    public void ResetPosition()
    {
        _rigidbody.position = Vector3.zero;
        _rigidbody.velocity = Vector3.zero;
        //AddStartingForce() we the removed it because we dont need the code to be going through more logic than it needs to be
    }
    //Making "force" possible to call in the "bouncy surface" script
    public void Bouncy(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ObstacleHealth health = collision.gameObject.GetComponent<ObstacleHealth>();

        if (health != null)
            health.TakeDamage(1);
    }
}
