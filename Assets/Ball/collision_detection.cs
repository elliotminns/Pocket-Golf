using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision_detection : MonoBehaviour
{

    public TrailRenderer tr;

    public SpriteRenderer sr;

    Vector3 resetPos;
    Rigidbody2D rb;

    public ParticleSystem explosion;

    public AudioSource audioData;

    public AudioClip pop;

    public AudioClip ballCol;

    public bool ballHasEntered = false;

    

    // Start is called before the first frame update
    void Start()
    {
        

        tr = GameObject.FindWithTag("Ball").GetComponent<TrailRenderer>();

        sr = GameObject.FindWithTag("Ball").GetComponent<SpriteRenderer>();

        rb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();

        resetPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "spike")
        {
            StartCoroutine("explosion_routine");
        }

        if (collision.gameObject.tag == "moving platform")
        {
            ballHasEntered = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "moving platform")
        {
            audioData.PlayOneShot(ballCol, 1f);

            ballHasEntered = false;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            if (ballHasEntered == true)
            {
                StartCoroutine("explosion_routine");
            }
        }
    }


    IEnumerator explosion_routine()
    {
        audioData.PlayOneShot(pop, 1f);

        var main = explosion.main;
        main.loop = false;

        sr.enabled = false;

        tr.enabled = false;

        explosion.Play();

        rb.velocity = new Vector2(0, 0);


        yield return new WaitForSeconds(0.5f);

        transform.position = resetPos;

        sr.enabled = true;

        tr.enabled = true;

        rb.velocity = new Vector2(0, 0);

    }
}
