using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class world_retry : MonoBehaviour
{
    public Scene scene;

    public Animator transition;

    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }


    public void Retry()
    {
        StartCoroutine(GameOver());
    }

    IEnumerator GameOver()
    {
        PlayerPrefs.SetInt("currentScore", 0);

        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(1f);
        //Load Scene
        if ((scene.name == "1-1") || (scene.name == "1-2") || (scene.name == "1-3") || (scene.name == "1-4") || (scene.name == "1-5") || (scene.name == "1-6") || (scene.name == "1-7") || (scene.name == "1-8"))
        {
            SceneManager.LoadScene("1-1");
        }
        else if ((scene.name == "2-1") || (scene.name == "2-2") || (scene.name == "2-3") || (scene.name == "2-4") || (scene.name == "2-5") || (scene.name == "2-6") || (scene.name == "2-7") || (scene.name == "2-8"))
        {
            SceneManager.LoadScene("2-1");
        }
        else if ((scene.name == "3-1") || (scene.name == "3-2") || (scene.name == "3-3") || (scene.name == "3-4") || (scene.name == "3-5") || (scene.name == "3-6") || (scene.name == "3-7") || (scene.name == "3-8"))
        {
            SceneManager.LoadScene("3-1");
        }
        else if ((scene.name == "4-1") || (scene.name == "4-2") || (scene.name == "4-3") || (scene.name == "4-4") || (scene.name == "4-5") || (scene.name == "4-6") || (scene.name == "4-7") || (scene.name == "4-8"))
        {
            SceneManager.LoadScene("4-1");
        }
    }

}
