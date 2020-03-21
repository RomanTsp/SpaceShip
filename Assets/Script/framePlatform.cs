using UnityEngine;
using System.Collections;

public class framePlatform : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 1.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 11f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 9f)
        {
            dirRight = true;
        }

    }
}