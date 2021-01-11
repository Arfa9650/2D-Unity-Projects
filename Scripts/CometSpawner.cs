using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject comet;

    float elapsedTime = 0;
    Quaternion rotation = new Quaternion(0, 0, 28.5f,180);
    private void Update()
    {
        elapsedTime += Time.deltaTime;
        if(elapsedTime>=10)
        {
            elapsedTime = 0;
            SpawnComet();
        }
    }


    void SpawnComet()
    {
        Vector2 position = new Vector2(-22, Random.Range(-8.5f,8.5f));
        Instantiate<GameObject>(comet, position, rotation).
            GetComponent<Rigidbody2D>().AddForce(Vector2.right * 20, ForceMode2D.Impulse);
    }
}
