using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class pause_menu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;

    public Animator transition;

    public Button pauseButton;

    float waitTime = 0.5f;

    public float counter = 0.5f;
    public float pauseUnlocked = 0;

    void OnEnable()
    {
        pauseButton.onClick.AddListener(Pause);
    }

    public void Resume()
    {
        StartCoroutine(waitForUnpause());
    }

    public void QuitButton()
    {
        StartCoroutine(BackLoadLevel());
    }

    IEnumerator BackLoadLevel()
    {
        PlayerPrefs.SetInt("currentScore", 0);

        //Restart Time
        Time.timeScale = 1f;
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(waitTime);
        //Load Scene
        SceneManager.LoadScene("Index");
        //Unpause Game
        gameIsPaused = false;
    }

    void Pause()
    {
        shots_new.pauseTrue = true;

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    IEnumerator waitForUnpause()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        yield return new WaitForSeconds(0.1f);
        gameIsPaused = false;
        shots_new.pauseTrue = false;
    }
}
