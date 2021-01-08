using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 5;
    public static int currentHealth;

    public Healthbar healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    

    void Update()
    {
        if (currentHealth > maxHealth)
            currentHealth = maxHealth;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    public static void HurtPlayer(int damageToGive)
    {
        currentHealth -= damageToGive;
        PlayerPrefs.SetInt("PlayerCurrentHealth", currentHealth);       
    }
}
