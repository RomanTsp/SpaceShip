using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointenemu : MonoBehaviour {

    public GameObject ExplosionGO;
    float waitTime;
    public float startWaitTime;

    public float speed;
    public Transform[] moveSpots;
    private int randomSpots;



	void Start () {

        waitTime = startWaitTime;
        randomSpots = Random.Range(0, moveSpots.Length);	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpots].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots[randomSpots].position) < 0.2f)
        {
            if (waitTime <=0)
            {
                randomSpots = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
	}
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("Hero"))
        {
            PlayExplosion();
           
        }
    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }
}

