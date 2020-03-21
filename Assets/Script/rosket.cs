using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rosket : MonoBehaviour
{

    private float timeBtwShots;
    public float startTimeBtwShot;
    public GameObject projectile;
    // Use this for initialization
    void Start()
    {

        timeBtwShots = startTimeBtwShot;
    }

    // Update is called once per frame
    void Update()
    {


        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShot;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }


}

