using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    float totalTime = 2;
    float elapsedTime = 0;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime>=totalTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                GameObject.FindWithTag("Player").
              GetComponent<ShipBehavior>().score += 1;
            }
            Destroy(gameObject);
        }
    }
}
