using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemuAgr : MonoBehaviour
{
    bool OnRight;
    public float speed;
    public float stoppingdistance;
    public float retreatDistance;

    private float timeBtwShots;
   public float startTimeBtwShot;

    public GameObject projectile;
    private Transform player;
    public bool FaceRight = true;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        timeBtwShots = startTimeBtwShot;
    }


    void Update()
    {
        if ((gameObject.transform.position.x <= player.position.x) && (FaceRight))
        {
            OnRight = true;
            Flip();
        }
        if ((gameObject.transform.position.x >= player.position.x) && (!FaceRight))
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


        if(timeBtwShots <=0)
        {
            Instantiate(projectile,transform.position,Quaternion.identity);
            timeBtwShots = startTimeBtwShot;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
    void Flip()
    {
        FaceRight = !FaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}
   