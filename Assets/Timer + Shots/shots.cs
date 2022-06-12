using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shots : MonoBehaviour
{

    public Rigidbody2D rb;

    public Collider2D holeCollider;

    public SpriteRenderer spriteRenderer;

    public int shotsLeft = 3;

    bool shotsTrue;

    public Sprite threeShots;

    public Sprite twoShots;

    public Sprite oneShot;

    public Sprite nullShots;

    public GameObject outofShots;

    public GameObject outofshotsEndless;

    public int endlessPlay;

    private void Awake()
    {
        pause_menu.gameIsPaused = false;

        shotsTrue = true;
    }

    void Start()
    {
        endlessPlay = PlayerPrefs.GetInt("endlessPlay");

        holeCollider = GameObject.FindWithTag("Hole").GetComponent<Collider2D>();
        rb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }
    

    public void Update()
    {

        if (holeCollider.bounds.Contains(GameObject.Find("Ball").transform.position))
        {
            shotsLeft = 3;

            shotsTrue = false;

            spriteRenderer.sprite = threeShots;
        }

        if (rb.velocity.magnitude >= 0.2)
        {
            shotsTrue = false;
        }
        else if (rb.velocity.magnitude <= 0.2)
        {
            shotsTrue = true;
        }
        else
        {

        }

        //shots not counting down here
        if (Input.GetMouseButtonUp(0))
        {
            if (shotsTrue == true && pause_menu.gameIsPaused == false)
            {
                shotsLeft--;
            }
        }

        if (shotsLeft == 2)
        {
            spriteRenderer.sprite = twoShots;
        }
        else if (shotsLeft == 1)
        {
            spriteRenderer.sprite = oneShot;
        }
        else if (shotsLeft == 0)
        {
            spriteRenderer.sprite = nullShots;
        }

        if (shotsLeft == 0 && shotsTrue == true)
        {
            if (endlessPlay == 0)
            {
                outofShots.SetActive(true);
            }
            else if (endlessPlay == 1)
            {
                outofshotsEndless.SetActive(true);
            }

        }

    }

    
    
}
