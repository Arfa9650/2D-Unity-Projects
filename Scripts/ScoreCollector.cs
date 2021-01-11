using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCollector : MonoBehaviour
{
    [SerializeField]
    Text main;
    private void Update()
    {
        if(GameObject.FindWithTag("MainCamera").GetComponent<GameInitializer>().gm)
        {
            main.text = "Game Over!";
        }
        if (GameObject.FindWithTag("Player") != null)
        {
            main.text = Convert.ToString(GameObject.FindWithTag("Player").
                GetComponent<ShipBehavior>().score);
        }
    }
}
