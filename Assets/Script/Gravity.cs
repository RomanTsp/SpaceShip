using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody2D rb;
     private bool top;
    private CharacterControllerScript2 player;

    private void Start()
    {
        player = GetComponent<CharacterControllerScript2>();
        rb = GetComponent<Rigidbody2D>();
        
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.gravityScale *= -1;
            Rotate();
        }
    }
    void Rotate()
        {
        if(top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180);
            player.facingRight = false;
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
            player.facingRight = true;
        }
        //player.facingRight = !player.facingRight;
        top = !top;
    }
}

	