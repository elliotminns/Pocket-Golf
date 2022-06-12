using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal_logic : MonoBehaviour
{
    public GameObject ball;
    public GameObject portal;

    public AudioSource audioData;

    public AudioClip portClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ball.transform.position = new Vector2(portal.transform.position.x, portal.transform.position.y);

            audioData.PlayOneShot(portClip, 1f);
        }
    }
}
