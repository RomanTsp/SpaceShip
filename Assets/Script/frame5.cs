using UnityEngine;
using System.Collections;

public class frame5 : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 2.2f)
        {
            dirRight = false;
        }

        if (transform.position.y <= 2.4f)
        {
            dirRight = true;
        }

    }
}