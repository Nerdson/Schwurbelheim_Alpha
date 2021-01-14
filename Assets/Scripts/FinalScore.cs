using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        var score = PlayerPrefs.GetInt("Final Score");
        scoreText.text = "Final Score: " + score;
    }

}
