using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifeEfect : MonoBehaviour {
    public GameObject ExplosionGO;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.CompareTag("life"))
            GetComponent<heals>().health += 1;
        PlayExplosion();
        
    





    }
    void PlayExplosion()
    {
        GameObject explosion = (GameObject)Instantiate(ExplosionGO);
        //положення вибуху
        explosion.transform.position = transform.position;
    }

}

