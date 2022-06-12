using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


[ExecuteInEditMode]
[RequireComponent(typeof(EdgeCollider2D))]
public class on_enter : MonoBehaviour
{

    public GameObject endOfLevelUI;

    bool isDone = false;

    public ParticleSystem explosion;

    CircleCollider2D circle_collider;

    public ParticleSystem conffeti;

    public AudioSource audioData;
    public AudioClip levelDone;

    public int endlessPlay;

    int currentScore;

    public Animator transition;

    public Rigidbody2D rb;

    public static bool addCoins;
    // Start is called before the first frame update
    void Start()
    {

        currentScore = PlayerPrefs.GetInt("currentScore");

        endlessPlay = PlayerPrefs.GetInt("endlessPlay");

        audioData = GameObject.FindWithTag("Hole").GetComponent<AudioSource>();

        rb = GameObject.FindWithTag("Ball").GetComponent<Rigidbody2D>();

        circle_collider = GetComponent<CircleCollider2D>();

        addCoins = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (circle_collider.bounds.Contains(GameObject.Find("Ball").transform.position))
        {
            rb.bodyType = RigidbodyType2D.Static;
            if (endlessPlay == 1)
            {
                conffeti.Play();
                StartCoroutine(Endless());
                shots_new.pauseTrue = true;
                PlayerPrefs.SetInt("collectedCoins", coin.collectedCoins);
            }
            else if (endlessPlay == 0)
            {
                conffeti.Play();
                EndOfLevel();
                shots_new.pauseTrue = true;
                PlayerPrefs.SetInt("collectedCoins", coin.collectedCoins);
            }

        }

        if (addCoins == true)
        {
            if (isDone == false)
            {
                audioData.PlayOneShot(levelDone, 0.5f);
                isDone = true;
                shots_new.pauseTrue = true;
            }
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("currentScore", 0);
    }

    public void EndOfLevel()
    {
        endOfLevelUI.SetActive(true);
        addCoins = true;
    }

    IEnumerator Endless()
    {
        string[] zones = new string[32] { "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "2-1", "2-2", "2-3", "2-4", "2-5", "2-6", "2-7", "2-8", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8" };
        int random = Random.Range(0, 32);

        PlayerPrefs.SetInt("currentScore", currentScore + 1);

        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(1);
        //Load Scene
        SceneManager.LoadScene(zones[random]);
    }


}
