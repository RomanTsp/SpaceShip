using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offGravity : MonoBehaviour
{
   
    void Start()
    {
        

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "offactivityGravity")
        {
         
            GetComponent<Gravity>().enabled =false;

            //GetComponent<CharacterControllerScript2>().moveSpeed = 5;
        }



    }
}