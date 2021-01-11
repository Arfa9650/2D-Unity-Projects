using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField]
    GameObject Laser;
    [SerializeField]
    float velocity=100;
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject Fire = Instantiate<GameObject>
                (Laser, transform.position, Quaternion.identity);
            Fire.GetComponent<Rigidbody2D>().
                AddForce(transform.up * velocity, ForceMode2D.Impulse);
        }
    }
}
