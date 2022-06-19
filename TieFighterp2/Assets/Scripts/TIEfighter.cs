using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TIEfighter : MonoBehaviour
{
    public Vector3 tieMovement;
    public float tieSpeed = 100;
    public Object laserPrefab;
    private Object currentLaser;
    public Vector3 spawnPosition;
    public AudioSource pewPew;

    public void TieFlip()
    { //Rotate the ship on button press
        this.transform.Rotate(100, 0, Time.deltaTime * this.tieSpeed); 
    }
    public void FireLaser()
    { //instantiate laser
        currentLaser = Instantiate(laserPrefab);
    }
}
