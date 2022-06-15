using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TIEfighter : MonoBehaviour
{
    public Vector3 tieMovement;
    public float tieSpeed = 100;

    public void TieFlip()
    {
        this.transform.Rotate(100, 0, Time.deltaTime * this.tieSpeed); 
    }
}
