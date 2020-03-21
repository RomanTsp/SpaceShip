using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    AudioSource audioData;
    public Transform firePoint;
    public GameObject bullet;
	
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            Shoot();
           

        }
	}

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
