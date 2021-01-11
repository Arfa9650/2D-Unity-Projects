using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehavior : MonoBehaviour
{
    [SerializeField]
    float thrust = 10.0f;
    bool oneFrameThrust = false;
    bool oneFrameStop = false;
    float colliderRadius;
    int health = 100;
    public int score = 0;
    void Start()
    {
        CircleCollider2D colliderRetrieval = GetComponent<CircleCollider2D>();
        colliderRadius = colliderRetrieval.radius;
    }

    void FixedUpdate()
    {
        if(health<=0)
        {
            Destroy(gameObject);
        }
        Quaternion rotation = transform.rotation;
        if(Input.GetAxis("Thrust")>0)
        {
            if (!oneFrameThrust)
            {
                oneFrameThrust = true;
                gameObject.GetComponent<Rigidbody2D>()
                    .AddForce(transform.up * thrust, ForceMode2D.Impulse);
            }
        }
        else { oneFrameThrust = false; }

        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput!=0)
        {
            rotation.z += horizontalInput * 10f * Time.deltaTime; 
        }
        transform.rotation = rotation;

        if(Input.GetAxis("Stop")>0)
        {
            if (!oneFrameStop)
            {
                oneFrameStop = true;
                gameObject.GetComponent<Rigidbody2D>().
                    AddForce(-transform.up * 2, ForceMode2D.Impulse);
            }
         }
        else { oneFrameStop = false; }

    }

    private void OnBecameInvisible()
    {
        Vector2 position = transform.position;
        if (position.x + colliderRadius > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenLeft;
        }
        else if (position.x - colliderRadius < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenRight;
        }
        if (position.y + colliderRadius > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenBottom;
        }
        else if (position.y - colliderRadius < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenTop;
        }
        transform.position = position;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Asteroid")
        {
            Debug.Log("GameOver");
            GameObject.FindWithTag("MainCamera").GetComponent<GameInitializer>().gm = true;
            Destroy(gameObject);
        }
    }
}
