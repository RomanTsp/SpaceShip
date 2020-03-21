using UnityEngine;
using System.Collections;

public class frame4 : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 6.4f)
        {
            dirRight = false;
        }

        if (transform.position.y <= 6.3f)
        {
            dirRight = true;
        }

    }
}