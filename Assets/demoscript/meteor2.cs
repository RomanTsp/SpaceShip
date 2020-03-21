using System.Collections;
using UnityEngine;

public class meteor2 : MonoBehaviour
{
    public GameObject meteor;
    void Start()
    {
        StartCoroutine(TestCoroutine());
    }

    IEnumerator TestCoroutine()
    {
        while (true)
        {
            Instantiate(meteor, new Vector2(Random.Range(-8f, 7f), 20f), Quaternion.identity);
            yield return new WaitForSeconds(38f);


        }
    }
}