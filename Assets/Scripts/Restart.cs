using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("R"))
        {
            SceneManager.LoadScene("01 Game");
        }
    }



}
