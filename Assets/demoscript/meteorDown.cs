using UnityEngine;

public class meteorDown : MonoBehaviour
{
    private float fallSpeaad = 1f;

    void Update ()
    {
        if (transform.position.y < -55f)
            Destroy(gameObject);
        transform.position -= new Vector3 ( 0,fallSpeaad *Time.deltaTime,0 );
    }
}
    