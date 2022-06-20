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
    public float tiltTime = 0.5f;
    private IEnumerator coroutine;

    public void TieFlip()
    { //Rotate the ship on button press
        LeanTween.rotate(gameObject, new Vector3(-180, 0, 0), tiltTime);
        StartCoroutine(returnToPose());
        
    }
    public void FireLaser()
    { //instantiate laser
        currentLaser = Instantiate(laserPrefab);
    }
    IEnumerator returnToPose()
    {
        yield return new WaitForSeconds(0.5f);
        LeanTween.rotate(gameObject, new Vector3(0, 0, 0), tiltTime);
        Debug.Log("here");
    }

}
