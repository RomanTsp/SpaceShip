using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lovychka : MonoBehaviour
{
    public GameObject ExplosionGO;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Hero"))
        {
            rb.isKinematic = false;
            
        }
    }

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Hero"))
        {
            PlayExplosion();
            Destroy(gameObject);
        }
    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}