using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class drag_and_shoot : MonoBehaviour
{
    public float power = 10f;
    public float maxDist = 1;
    public Rigidbody2D rb;
    public Transform tf;
    public Collider2D ballCollider;

    public Vector2 minPower;
    public Vector2 maxPower;

    public bool levelComplete;

    line_path lp;

    Camera cam;
    Vector2 force;
    Vector3 startPoint;
    Vector3 endPoint;

    public AudioSource audioData;
    public AudioClip ballHit;
    public AudioClip colHit;
    public AudioClip coin;

    public Sprite ball;
    public Sprite smile;
    public Sprite robot;
    public Sprite planet;
    public Sprite bBall;
    public Sprite eye;

    public SpriteRenderer sr;

    public Collider2D holeCollider;

    public LineRenderer lr;

    public TrailRenderer tr;

    //public Rigidbody2D rb;

    public void Start()
    {

        ballCollider = GameObject.FindWithTag("Ball").GetComponent<Collider2D>();

        rb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();

        holeCollider = GameObject.FindWithTag("Hole").GetComponent<Collider2D>();

        sr = GameObject.FindWithTag("Ball").GetComponent<SpriteRenderer>();

        audioData = GameObject.FindWithTag("Ball").GetComponent<AudioSource>();

        rb.velocity = new Vector2 (0, 0);

        if (PlayerPrefs.GetInt("ballSkin") == 0)
        {
            sr.sprite = ball;
        }
        else if (PlayerPrefs.GetInt("ballSkin") == 1)
        {
            sr.sprite = smile;
        }
        else if (PlayerPrefs.GetInt("ballSkin") == 2)
        {
            sr.sprite = robot;
        }
        else if (PlayerPrefs.GetInt("ballSkin") == 3)
        {
            sr.sprite = planet;
        }
        else if (PlayerPrefs.GetInt("ballSkin") == 4)
        {
            sr.sprite = bBall;
        }
        else if (PlayerPrefs.GetInt("ballSkin") == 5)
        {
            sr.sprite = eye;
        }


        cam = Camera.main;
        lp = GetComponent<line_path>();
    }

    private void Update()
    {
        if (pause_menu.gameIsPaused == false)
        {
            bool line;

            if (Input.GetMouseButtonDown(0))
            {
                startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                startPoint.z = 1;
            }

            if (rb.velocity.magnitude < 0.2)
            {
                rb.velocity = new Vector2(0, 0);
            }

            if (Input.GetMouseButtonUp(0) && rb.velocity.magnitude == 0)
            {
                endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
                endPoint.z = 1;

                force = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));

                rb.AddForce(force * power, ForceMode2D.Impulse);

                lp.EndLine();


                if (holeCollider.bounds.Contains(GameObject.Find("Ball").transform.position))
                {
                
                }
                else if (pause_menu.gameIsPaused == false)
                {
                    audioData.PlayOneShot(ballHit, 1f);
                }
                    
            }

            if (Input.GetMouseButton(0) && rb.velocity.magnitude == 0)
            {
                line = true;

                Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
                Vector3 ballPos = GameObject.Find("Ball").transform.position;
                Vector3 lineEnd = ballPos + (mousePos - startPoint);

                mousePos.z = 1;
                ballPos.z = 1;
                lineEnd.z = 1;

                if (line == true)
                {
                    lp.RenderLine(ballPos, lineEnd);
                }
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == ("wall"))
        {
            audioData.PlayOneShot(colHit, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            audioData.PlayOneShot(coin, 0.1f);
        }
    }
}
