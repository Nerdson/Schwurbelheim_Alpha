using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;
    public TextMeshProUGUI scoreText;
    public int score;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


    public void AddScore(int scoreValue = 100)
    {
        score += 100;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("GameOver", 1f);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("02 Game Over LOSE");
    }
}
