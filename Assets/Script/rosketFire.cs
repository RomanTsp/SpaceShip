using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rosketFire : MonoBehaviour
{
    public GameObject ExplosionGO;
    public Vector2 direction;
    public float speed;
    void Start()
    {
        Destroy(gameObject, 11);
     

    }

    void FixedUpdate()
    {
        transform.Translate(direction.normalized*speed);
    }
  void OnCollisionEnter2D(Collision2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if (col.gameObject.tag == "Player" )
        {
            PlayExplosion();


            //Знищити корабель
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


