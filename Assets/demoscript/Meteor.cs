using System.Collections;
using UnityEngine;

public class Meteor : MonoBehaviour {
    public GameObject meteor;
    void Start()
    {
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        while (true)
        {
            Instantiate(meteor, new Vector2(Random.Range(-9f, 9f), 9f), Quaternion.identity);
            yield return new WaitForSeconds(25f);


        }
    }
}