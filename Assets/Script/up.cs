using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up : MonoBehaviour
{
    public GameObject ExplosionGO;
    private Rigidbody2D rb;
    public float speed;
    public float stoppingdistance;
    public float retreatDistance;

    Animator animator;

    private Transform player;
    public int Speed = 1;
    public Transform Player;

    bool OnRight;
    public bool FaceRight = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if ((gameObject.transform.position.x <= Player.position.x) && (FaceRight))
        {
            OnRight = true;
            Flip();
        }
        if ((gameObject.transform.position.x >= Player.position.x) && (!FaceRight))
        {
            OnRight = false;
            Flip();
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingdistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, player.position) < stoppingdistance && (Vector2.Distance(transform.position, player.position) > retreatDistance))
        {
            transform.position = this.transform.position;
        }
        else if (Vector2.Distance(transform.position, player.position) < retreatDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }

    }



    void Flip()
    {
        FaceRight = !FaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.name == "colaider")
            Destroy(gameObject);


        if (col.gameObject.name == "cub")
            rb.AddForce(Vector2.up * 250f);

        if (col.gameObject.name == "Hero")
            PlayExplosion();
     


    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }

}