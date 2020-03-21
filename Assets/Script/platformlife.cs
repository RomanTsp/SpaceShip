using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class platformlife : MonoBehaviour {

   
  public  float speed = 1f;

    bool moveingRight = true;

    void Update()
    {
        if (transform.position.x > 2.8f)
        {
            moveingRight = false;
        }
        else if (transform.position.x < 1f)
        {
            moveingRight = true;
        }
        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
                
        }
    }