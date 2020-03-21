﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_lvl2 : MonoBehaviour {

    public int health = 2;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
        {
        Destroy(gameObject);

    }
}