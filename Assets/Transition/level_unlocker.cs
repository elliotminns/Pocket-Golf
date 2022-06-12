using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_unlocker : MonoBehaviour
{
    public Collider2D holeCollider;

    Scene scene;
    string sceneName;
    int current;


    private void Start()
    {
        holeCollider = GameObject.FindWithTag("Hole").GetComponent<Collider2D>();

        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;
    }

    void Update()
    {
        if (holeCollider.bounds.Contains(GameObject.Find("Ball").transform.position))
        {

                if (sceneName == "1-8")
                {
                    current = PlayerPrefs.GetInt("Unlocked");

                    if (current >= 1)
                    {

                    }
                    else
                    {
                        PlayerPrefs.SetInt("Unlocked", 1);
                    }
                }

            if (sceneName == "2-8")
            {
                current = PlayerPrefs.GetInt("Unlocked");

                if (current >= 2)
                {

                }
                else
                {
                    PlayerPrefs.SetInt("Unlocked", 2);
                }
            }

            if (sceneName == "3-8")
            {
                current = PlayerPrefs.GetInt("Unlocked");

                if (current >= 3)
                {

                }
                else
                {
                    PlayerPrefs.SetInt("Unlocked", 3);
                }
            }

            if (sceneName == "4-8")
            {
                current = PlayerPrefs.GetInt("Unlocked");

                if (current >= 4)
                {

                }
                else
                {
                    PlayerPrefs.SetInt("Unlocked", 4);
                }
            }
        }
    }
}
