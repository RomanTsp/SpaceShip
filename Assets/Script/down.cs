using UnityEngine;
using System.Collections;

public class down: MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 5.4f)
        {
            dirRight = false;
        }

        if (transform.position.y <= 0.75f)
        {
            dirRight = true;
        }

    }
}