using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comet : MonoBehaviour
{
    float elapsedTime = 0;
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 5)
        {
            elapsedTime = 0;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if (GameObject.FindWithTag("Player") != null)
            {
                GameObject.FindWithTag("Player").
                GetComponent<ShipBehavior>().score += 5;
            }
            Destroy(gameObject);
        }
    }
}
