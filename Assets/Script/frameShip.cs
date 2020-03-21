using UnityEngine;
using System.Collections;

public class frameShip : MonoBehaviour
{

    private bool dirRight = true;
    public float speed = 3.0f;


    void FixedUpdate()
    {

        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= 4f)
        {
            dirRight = false;
        }

        if (transform.position.x <= -4f)
        {
            dirRight = true;
        }

    }
}