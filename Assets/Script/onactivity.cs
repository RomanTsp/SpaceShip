using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onactivity : MonoBehaviour {

    public GameObject enemy;
   



        void Start()
        {
        enemy.SetActive(false);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            enemy.SetActive(true);

        }

    
       
        }
    }