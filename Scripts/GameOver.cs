using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    
    public bool gameOver = false;


    private void Update()
    {
        if(gameOver)
        {
            gameObject.SetActive(true);
        }
    }
}
