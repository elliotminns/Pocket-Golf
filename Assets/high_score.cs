using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class high_score : MonoBehaviour
{
    public GameObject currentScoreObject;

    public TextMeshProUGUI currentScoreText;

    public TextMeshProUGUI highScoreText;

    int currentScore;

    int highScore;

    void Start()
    {
        if (PlayerPrefs.GetInt("endlessPlay") == 0)
        {
            currentScoreObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("endlessPlay") == 1)
        {
            currentScoreObject.SetActive(true);
        }
    }

    void Update()
    {
        currentScore = PlayerPrefs.GetInt("currentScore");
        highScore = PlayerPrefs.GetInt("highScore");

        if (highScore <= currentScore)
        {
            PlayerPrefs.SetInt("highScore", currentScore); ;
        }
        else
        {

        }

        

        currentScoreText.text = currentScore.ToString();
        highScoreText.text = highScore.ToString();
    }
}
