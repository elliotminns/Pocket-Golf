using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class settings_menu : MonoBehaviour
{
    public GameObject settingsMenuUI;

    int highScoreInt;
    public void Settings()
    {
        settingsMenuUI.SetActive(true);
    }

    public void Back()
    {
        settingsMenuUI.SetActive(false);
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
}
