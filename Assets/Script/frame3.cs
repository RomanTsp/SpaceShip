using UnityEngine;
using System.Collections;

public class frame3 : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 2.8f)
        {
            dirRight = false;
        }

        if (transform.position.y <= 2.7f)
        {
            dirRight = true;
        }

    }
}