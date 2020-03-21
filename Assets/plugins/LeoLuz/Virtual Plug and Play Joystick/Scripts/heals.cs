﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class heals : MonoBehaviour
{

    public int health;
    public int numberOfLives;
    

    public Image[] lives;
    public Sprite fullLive;
    public Sprite emptyLive;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health > numberOfLives)
        {
            health = numberOfLives;
        }
        for (int i = 0; i < lives.Length; i++)
        {
            if (i < health)
            {
                lives[i].sprite = fullLive;
            }
            else
            {
                lives[i].sprite = emptyLive;
            }

            if (i < numberOfLives)
            {
                lives[i].enabled = true;
            }
            else
            {
                lives[i].enabled = false;
            }

            if (health <= 0)
            {
                SceneManager.LoadScene("Game over");
            }


        }
        
           
        }

    }

