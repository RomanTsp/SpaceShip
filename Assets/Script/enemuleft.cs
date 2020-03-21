using UnityEngine;
using System.Collections;

public class frame : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 2.0f;

    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 36f)
        {
            dirRight = false;
        }

        if (transform.position.x <= 20f)
        {
            dirRight = true;
        }

    }
}