using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    float elapsedTime = 0;

    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime>=5)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Laser")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
