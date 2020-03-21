using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eneuBulet_platform : MonoBehaviour {

    public float speed;
    bool OnRight;
    private Transform player;
    private Vector2 target;
    public bool FaceRight = true;
    public GameObject ExplosionGO;

    void Start () {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
	}
	

	void Update () {

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
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
	}
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"));
        {
            DestroyProjectile();
        }
        
    }

    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
    void Flip()
    {
        FaceRight = !FaceRight;
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }
    void OnCollisionEnter2D(Collision2D col)
    {

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

