using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level_select : MonoBehaviour
{
    public Button w1l2, w1l3, w1l4, w1l5, w1l6, w1l7, w1l8, w2l1, w2l2, w2l3, w2l4, w2l5, w2l6, w2l7, w2l8, w3l1, w3l2, w3l3, w3l4, w3l5, w3l6, w3l7, w3l8, w4l1, w4l2, w4l3, w4l4, w4l5, w4l6, w4l7, w4l8, endless;
    int levelPassed;

    public Animator transition;

    public Color color;

    public ColorBlock colorBlockHuman;
    private void Start()
    {
        //PlayerPrefs.SetInt("Unlocked", 0);

        levelPassed = PlayerPrefs.GetInt("Unlocked");

        w1l2.interactable = false;
        w1l3.interactable = false;
        w1l4.interactable = false;
        w1l5.interactable = false;
        w1l6.interactable = false;
        w1l7.interactable = false;
        w1l8.interactable = false;

        w2l1.interactable = false;
        w2l2.interactable = false;
        w2l3.interactable = false;
        w2l4.interactable = false;
        w2l5.interactable = false;
        w2l6.interactable = false;
        w2l7.interactable = false;
        w2l8.interactable = false;

        w3l1.interactable = false;
        w3l2.interactable = false;
        w3l3.interactable = false;
        w3l4.interactable = false;
        w3l5.interactable = false;
        w3l6.interactable = false;
        w3l7.interactable = false;
        w3l8.interactable = false;

        w4l1.interactable = false;
        w4l2.interactable = false;
        w4l3.interactable = false;
        w4l4.interactable = false;
        w4l5.interactable = false;
        w4l6.interactable = false;
        w4l7.interactable = false;
        w4l8.interactable = false;

        endless.interactable = false;

        var newColorBlock = w1l2.colors;
        newColorBlock.disabledColor = new Color(1, 1, 1, 0.5f);

        switch (levelPassed)
        {
            case 1:
                w2l1.interactable = true;

                w1l2.colors = newColorBlock;
                w1l3.colors = newColorBlock;
                w1l4.colors = newColorBlock;
                w1l5.colors = newColorBlock;
                w1l6.colors = newColorBlock;
                w1l7.colors = newColorBlock;
                w1l8.colors = newColorBlock;
                break;
            case 2:
                w2l1.interactable = true;
                w3l1.interactable = true;

                w1l2.colors = newColorBlock;
                w1l3.colors = newColorBlock;
                w1l4.colors = newColorBlock;
                w1l5.colors = newColorBlock;
                w1l6.colors = newColorBlock;
                w1l7.colors = newColorBlock;
                w1l8.colors = newColorBlock;

                w2l2.colors = newColorBlock;
                w2l3.colors = newColorBlock;
                w2l4.colors = newColorBlock;
                w2l5.colors = newColorBlock;
                w2l6.colors = newColorBlock;
                w2l7.colors = newColorBlock;
                w2l8.colors = newColorBlock;
                break;
            case 3:
                w2l1.interactable = true;
                w3l1.interactable = true;
                w4l1.interactable = true;

                w1l2.colors = newColorBlock;
                w1l3.colors = newColorBlock;
                w1l4.colors = newColorBlock;
                w1l5.colors = newColorBlock;
                w1l6.colors = newColorBlock;
                w1l7.colors = newColorBlock;
                w1l8.colors = newColorBlock;

                w2l2.colors = newColorBlock;
                w2l3.colors = newColorBlock;
                w2l4.colors = newColorBlock;
                w2l5.colors = newColorBlock;
                w2l6.colors = newColorBlock;
                w2l7.colors = newColorBlock;
                w2l8.colors = newColorBlock;

                w3l2.colors = newColorBlock;
                w3l3.colors = newColorBlock;
                w3l4.colors = newColorBlock;
                w3l5.colors = newColorBlock;
                w3l6.colors = newColorBlock;
                w3l7.colors = newColorBlock;
                w3l8.colors = newColorBlock;
                break;
            case 4:
                w2l1.interactable = true;
                w3l1.interactable = true;
                w4l1.interactable = true;
                endless.interactable = true;

                w1l2.colors = newColorBlock;
                w1l3.colors = newColorBlock;
                w1l4.colors = newColorBlock;
                w1l5.colors = newColorBlock;
                w1l6.colors = newColorBlock;
                w1l7.colors = newColorBlock;
                w1l8.colors = newColorBlock;

                w2l2.colors = newColorBlock;
                w2l3.colors = newColorBlock;
                w2l4.colors = newColorBlock;
                w2l5.colors = newColorBlock;
                w2l6.colors = newColorBlock;
                w2l7.colors = newColorBlock;
                w2l8.colors = newColorBlock;

                w3l2.colors = newColorBlock;
                w3l3.colors = newColorBlock;
                w3l4.colors = newColorBlock;
                w3l5.colors = newColorBlock;
                w3l6.colors = newColorBlock;
                w3l7.colors = newColorBlock;
                w3l8.colors = newColorBlock;

                w4l2.colors = newColorBlock;
                w4l3.colors = newColorBlock;
                w4l4.colors = newColorBlock;
                w4l5.colors = newColorBlock;
                w4l6.colors = newColorBlock;
                w4l7.colors = newColorBlock;
                w4l8.colors = newColorBlock;
                break;
        }
    }

    
    public void levelToLoad(int level)
    {
        StartCoroutine(loadToLevel(level));
    }
    

    IEnumerator loadToLevel(int level)
    {
        //Play Animation
        transition.SetTrigger("Start");
        //Wait
        yield return new WaitForSeconds(0.5f);
        //Load Scene
        SceneManager.LoadScene(level);
    }

    public void notEndless()
    {
        PlayerPrefs.SetInt("endlessPlay", 0);
    }
}