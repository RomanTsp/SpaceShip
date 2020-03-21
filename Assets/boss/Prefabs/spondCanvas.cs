using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spondCanvas : MonoBehaviour {
    private AudioSource audioSrc;
    private float musisVolume = 1f;
	// Use this for initialization
	void Start () {
        audioSrc = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        audioSrc.volume = musisVolume;	
	}
    public void SetVolume(float vol)
    {
        musisVolume = vol;
    }
}
