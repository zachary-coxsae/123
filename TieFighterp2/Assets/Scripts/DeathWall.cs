using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathWall : MonoBehaviour
{ 
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            Destroy(other.gameObject);
        }
    }
}
