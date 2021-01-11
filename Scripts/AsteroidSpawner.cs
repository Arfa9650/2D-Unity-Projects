using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Asteroid;

    float totalTime = 3;
    float elapsedTime = 0;

    private void Update()
    {
        if(totalTime<=0.5)
        {
            totalTime = 1;
        }
        elapsedTime += Time.deltaTime;
        if(elapsedTime>=totalTime)
        {
            elapsedTime = 0;
            SpawnAsteroid();
            totalTime -= 0.1f;
        }
    }

    void SpawnAsteroid()
    {
        Vector2 position = new Vector2(Random.Range(-19, 20), 11);
        Instantiate<GameObject>(Asteroid, position, Quaternion.identity).
            GetComponent<Rigidbody2D>().AddForce(-transform.up*4, ForceMode2D.Impulse);
    }
}
