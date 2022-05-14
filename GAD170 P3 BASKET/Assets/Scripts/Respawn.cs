using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Respawn : MonoBehaviour
{
    public int respawnTimer;
    public ObstacleHealth[] obstacleLibrary; //sets up a library from which obstacles can be instantiated
    ObstacleHealth currentObstacle;



    public void ObstacleSpawn()
    { //Picks one randomly from the library then places them on to a spawn point
        int randomInt = Random.Range(0, obstacleLibrary.Length);
        currentObstacle = Instantiate(obstacleLibrary[randomInt]);
        currentObstacle.transform.position = this.transform.position;
    }
    private void Start()
    { //Spawns obstacle at game start
        ObstacleSpawn();
    }
    private void OnEnable()
    { //subcribes to respawn events once the obstacle gets destroyed
        GameEvents.OnObstacleDestroyed += ObstacleRespawn;
    }
    private void OnDisable()
    { //unsubscribes from game events
        GameEvents.OnObstacleDestroyed -= ObstacleRespawn;
    }
    private void ObstacleRespawn(ObstacleHealth destroyedObstacle)
    { //Checks if the obstacle is destroyed, then starts the timer for respawn if it is
        if (destroyedObstacle == currentObstacle)
            StartCoroutine(RespawnTimer());
    }
    private IEnumerator RespawnTimer()
    { //waits 5 seconds before respawning the obstacles
        yield return new WaitForSeconds(5);
        ObstacleSpawn();
    }
}
