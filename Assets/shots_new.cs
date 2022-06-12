using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class shots_new : MonoBehaviour
{
    public SpriteRenderer sr;

    public Sprite allShots;
    public Sprite twoShots;
    public Sprite oneShot;
    public Sprite nullShots;

    public Rigidbody2D rb;

    public Collider2D hc;

    public bool shotsTrue;

    public static bool pauseTrue;

    public int shotsLeft;

    public GameObject outofShots;
    public GameObject outofShotsEndless;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    private void Start()
    {


        pauseTrue = false;

        shotsLeft = 4;

        pause_menu.gameIsPaused = false;
    }
    private void Update()
    {

        if (rb.velocity.magnitude == 0)
        {
            shotsTrue = true;
        }
        else if (rb.velocity.magnitude > 0)
        {
            shotsTrue = false;
        }

        if (Input.GetMouseButtonUp(0) && shotsTrue == true && pauseTrue == false)
        {
            if (shotsLeft != 0)
            {
                shotsLeft--;
            }
        }

        if (shotsLeft == 0)
        {
            rb.bodyType = RigidbodyType2D.Static;
            if (PlayerPrefs.GetInt("endlessPlay") == 0 && shotsTrue == true)
            {
                outofShots.SetActive(true);
                pause_menu.gameIsPaused = true;
            }
            else if (PlayerPrefs.GetInt("endlessPlay") == 1 && shotsTrue == true)
            {
                outofShotsEndless.SetActive(true);
                pause_menu.gameIsPaused = true;
            }
        }


        if (hc.bounds.Contains(GameObject.Find("Ball").transform.position))
        {
            shotsTrue = false;
        }

        if (shotsLeft == 4)
        {
            sr.sprite = allShots;
        }
        else if (shotsLeft == 3)
        {
            sr.sprite = twoShots;
        }
        else if (shotsLeft == 2)
        {
            sr.sprite = oneShot;
        }
        else if (shotsLeft == 1)
        {
            sr.sprite = nullShots;
        }
    }

}
