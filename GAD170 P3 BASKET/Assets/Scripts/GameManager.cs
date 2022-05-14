using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public PlayerPaddle paddle;
    public Text score;
    public Image loseScreen;
    public int _playerScore;
    private List<ObstacleHealth> activeObstacles = new List<ObstacleHealth>();
    public ObstacleHealth[] obstacleLibrary;
    public Transform[] obstacleSpawnPoints;
    public object activeList;
    private float respawnTime;
    public void PlayerScores()
    {
        //_playerScore is the actual score for the player paddle, to show this in
        //the UI we need a playerScoreText variable to apply the new score value to
        _playerScore += 3;
        this.score.text = _playerScore.ToString();
        Debug.Log("score");
    }
    public void LoseScore()
    {
        //Player loses score when the miss the ball and it falls past them.
        _playerScore--;
        this.score.text = _playerScore.ToString();
        Debug.Log("ouch");
    }
    public void RestartGame()
    {
        // restarts game w/ the reset button
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
