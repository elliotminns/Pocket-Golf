using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class level_loader : MonoBehaviour
{
    public float timerPause;

    public Rigidbody2D rb;

    public Collider2D holeCollider;

    public Animator transition;

    GameObject ball;

    SpriteRenderer rend;

    public Button nextButton;

    public Scene scene;

    void OnEnable()
    {

        nextButton.onClick.AddListener(Wait);

    }

    public void Start()
    {
        scene = SceneManager.GetActiveScene();

        ball = GameObject.FindWithTag("Ball");
        holeCollider = GameObject.FindWithTag("Hole").GetComponent<Collider2D>();
        rb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();
        rend = GameObject.FindWithTag("Ball").GetComponent<SpriteRenderer>();
    }

    public void Update()
    { 
        if (holeCollider.bounds.Contains(GameObject.Find("Ball").transform.position))
        {
            ball.layer = 9;
        }
    }

    IEnumerator LoadLevel()
    {
        
            //Play Animation
            transition.SetTrigger("Start");
            //Wait
            yield return new WaitForSeconds(1);
            //Load Scene
            if ((scene.name == "1-8") || (scene.name == "2-8") || (scene.name == "3-8") || (scene.name == "4-8"))
            {
                SceneManager.LoadScene("Level Select");
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            }


    }

    void Wait()
    {
        StartCoroutine(LoadLevel());
    }
}
