using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 1;
    public float speed = 5f;
    public Rigidbody2D rb;
    public GameObject explosionTwo;
    public GameObject explosion;
    private Animator camAnim;
    // Use this for initialization
    void Start()
    {
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 5);

    }
    

    private void OnTriggerEnter2D(Collider2D  hitInfo)

    {
       Enemy_lvl2 enemy = hitInfo.GetComponent<Enemy_lvl2>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        {

            PlayExplosion();
            Destroy(gameObject);
        }
        if (hitInfo.CompareTag("Boss"))
        {
          
            hitInfo.GetComponent<Boss>().health -= damage;
            Instantiate(explosion, transform.position, Quaternion.identity);
            Instantiate(explosionTwo, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(explosionTwo);
        //положення вибуху
        explosion.transform.position = transform.position;
    }

}


	