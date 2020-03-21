using UnityEngine;
using System.Collections;

public class frame2 : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;
     

    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.position.y >= 0.10f)
        {
            dirRight = false;
        }

        if (transform.position.y <= 0f)
        {
            dirRight = true;
        }

    }
}