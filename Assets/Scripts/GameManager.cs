using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnded = false;


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
        SceneManager.LoadScene("Game Over");
    }
}
