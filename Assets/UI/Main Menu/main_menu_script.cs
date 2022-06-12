using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_script : MonoBehaviour
{
    public Animator transition;

    //defines how long the couritine should wait before loading the new scene
    float waitTime = 0.5f;

    public void PlayButton()
    {
        StartCoroutine(PlayLoadLevel());
    }

    public void StoreButton()
    {
        StartCoroutine(StoreLoadLevel());
    }

    public void SettingsButton()
    {
        StartCoroutine(SettingsLoadLevel());
    }

    public void BackButtonUI()
    {
        StartCoroutine(BackLoadLevel());
    }


    IEnumerator PlayLoadLevel()
    {
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(waitTime);
        //Load Scene
        SceneManager.LoadScene("Level Select");
    }

    IEnumerator StoreLoadLevel()
    {
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(waitTime);
        //Load Scene
        SceneManager.LoadScene("Store");
    }

    IEnumerator SettingsLoadLevel()
    {
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(waitTime);
        //Load Scene
        SceneManager.LoadScene("Settings");
    }

    IEnumerator BackLoadLevel()
    {
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(waitTime);
        //Load Scene
        SceneManager.LoadScene("Index");
    }
}
