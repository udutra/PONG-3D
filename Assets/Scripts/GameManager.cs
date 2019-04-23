using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ball, ballInstance;
    public int player1Score, player2Score, scoreLimit;
    public string currentScene;
    public KeyCode restartButton;
    public bool gameOver;
    public Text player1ScoreCounter, player2ScoreCounter, playerVictoryText;
    public GameObject gameOverPanel;

    private void Start()
    {
        SetBall();
        gameOver = false;
        currentScene = SceneManager.GetActiveScene().name;
    }
    private void Update()
    {
        if (gameOver)
        {
            if (Input.GetKey(restartButton))
            {
                RestartGame();
            }
        }
    }

    private void SetBall()
    {
        ballInstance = Instantiate(ball);
        ballInstance.GetComponent<Ball>().gameManager  = gameObject.GetComponent<GameManager>();
    }

    

    public void UpdatePlayerScore(int p)
    {
        if (p == 1)
        {
            player1Score += 1;
            player1ScoreCounter.text = player1Score.ToString();
            Destroy(ballInstance, 1f);
            
            if(player1Score == scoreLimit)
            {
                gameOver = true;
                gameOverPanel.SetActive(true);
                playerVictoryText.text = "Player 1 - Win!";
            }
            else
            {
                SetBall();
            }
        }
        else if (p == 2)
        {
            player2Score += 1;
            Destroy(ballInstance, 1f);
            player2ScoreCounter.text = player2Score.ToString();
            if (player2Score == scoreLimit)
            {
                  gameOver = true;
                gameOverPanel.SetActive(true);
                playerVictoryText.text = "Player 2 - Win!";
            }
            else
            {
                SetBall();
            }
        }
    }
    private void RestartGame()
    {
        SceneManager.LoadScene(currentScene);
    }
}