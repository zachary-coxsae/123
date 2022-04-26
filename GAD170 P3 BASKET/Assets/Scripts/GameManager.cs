using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public Ball ball;
    public PlayerPaddle paddle;
    public Text score;
    public int _playerScore;
    private List<ObstacleHealth> activeObstacles = new List<ObstacleHealth>();
    public ObstacleHealth[] obstacleLibrary;
    public Transform[] obstacleSpawnPoints;
    public object activeList;
    private float respawnTime;

    /*private void Start()
    {
        ObstacleSpawn();
    }*/
   
    public void PlayerScores()
    {
        //_playerScore is the actual score for the player paddle, to show this in
        //the UI we need a playerScoreText variable to apply the new score value to
        _playerScore++;
        this.score.text = _playerScore.ToString();
        Debug.Log("score");
    }


    //destroy obstacle and replace wth the powerups
    //spawn in obstacles
  /*  private void ObstacleSpawn()
    {
        foreach( Transform sp in obstacleSpawnPoints)
        {
            if( sp == null ) { continue; }
            int randomInt = Random.Range(0, obstacleLibrary.Length);
            ObstacleHealth newObstacle = Instantiate(obstacleLibrary[randomInt]);
            newObstacle.transform.position = sp.position;
        }
    }*/
   /* private void ObstacleRespawn()
    {
        if (obstacleSpawnPoints == null)
        {

        }

    }*/
    //damage system 
    //scoring linked to the hoops 

}
