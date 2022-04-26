using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Respawn : MonoBehaviour
{
    public int respawnTimer;
    public ObstacleHealth[] obstacleLibrary;
    ObstacleHealth currentObstacle;



    public void ObstacleSpawn()
    {
        int randomInt = Random.Range(0, obstacleLibrary.Length);
        currentObstacle = Instantiate(obstacleLibrary[randomInt]);
        currentObstacle.transform.position = this.transform.position;
    }
    private void Start()
    {
        ObstacleSpawn();
    }
    private void OnEnable()
    {
        GameEvents.OnObstacleDestroyed += ObstacleRespawn;
    }
    private void OnDisable()
    {
        GameEvents.OnObstacleDestroyed -= ObstacleRespawn;
    }
    private void ObstacleRespawn(ObstacleHealth destroyedObstacle)
    {
        if (destroyedObstacle == currentObstacle)
            StartCoroutine(RespawnTimer());
    }
    private IEnumerator RespawnTimer()
    {
        yield return new WaitForSeconds(5);
        ObstacleSpawn();
    }
}
