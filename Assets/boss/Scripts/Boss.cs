using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public GameObject ExplosionGO;
    public int health;
    private float timeBtwDamage = 1.5f;


    public Animator camAnim;
    public Slider healthBar;
    private Animator anim;
    public bool isDead;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {

        if (health <= 25)
        {
            anim.SetTrigger("stageTwo");
        }

        if (health <= 0)
        {
            anim.SetTrigger("death");
        }

        // give the player some time to recover before taking more damage !
        if (timeBtwDamage > 0)
        {
            timeBtwDamage -= Time.deltaTime;
        }

        healthBar.value = health;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // deal the player damage ! 
        if (other.CompareTag("Player") && isDead == false)
        {
         
            if (timeBtwDamage <= 0)
            {
                camAnim.SetTrigger("shake");
            
               
           

            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.name == "Hero")
          
        PlayExplosion();
    

    }

        void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}
