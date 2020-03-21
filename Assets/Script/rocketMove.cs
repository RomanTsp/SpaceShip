using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketMove : MonoBehaviour

{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.x >= 1f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 0f)
        {
            dirRight = true;
        }

    }
}