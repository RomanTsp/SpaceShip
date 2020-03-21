using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
    public GameObject ExplosionGO;
    
    void OnTriggerEnter2D(Collider2D col)
    {
        //Виявленя зіткнення ворожого корабля з кораблем гравця ,або з кулею гравця
        if ((col.tag == "PlayerShipTag") || (col.tag == "PlayerBulletTag"))
        {
            PlayExplosion();


            //Знищити корабель
            //Destroy(gameObject);
        }
    }


    


void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }

}


