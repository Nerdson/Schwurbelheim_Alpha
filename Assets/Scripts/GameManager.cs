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
    public AudioSource pling;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


    public void AddScore(int scoreValueParam)
    {
        // variable EnemyAi.scoreValue is the argument filled into the placeholder variable scoreValue 
        // the value itself is defined on the enemy game objects
        score += scoreValueParam;
        UpdateScore();
        pling.Play();
    }

    public void AddTPScore(int tpScoreValueParam)
    {
        score += tpScoreValueParam;
        UpdateScore();
        pling.Play();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
        PlayerPrefs.SetInt("Final Score", score);
    }

    public void EndGame()
    {
        if(gameEnded == false)
        {
            gameEnded = true;
            Invoke("GameOver", 0.5f);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("02 Game Over LOSE");
    }
}
