using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{
    public int tpScoreValue;
    public int healthToGive;
    protected GameManager gameManager;

    public AudioSource pickUpSounds;

    private HealthSystem _healthSystemScript;


    protected void Start()
    {
        GameObject gameManagerObject = GameObject.FindWithTag("GameManager");
        if (gameManagerObject != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }

        _healthSystemScript = GameObject.Find("Player").GetComponent<HealthSystem>();
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<PlayerController>())
        {
            _healthSystemScript.HealPlayer(healthToGive);

            gameManager.AddTPScore(tpScoreValue);

            pickUpSounds.Play();

            Destroy(gameObject);
        }
    }
}
