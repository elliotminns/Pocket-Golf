using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mute_audio : MonoBehaviour
{

    public Toggle toggle;

    private void Start()
    {
        toggle = GetComponent<Toggle>();

        if (PlayerPrefs.GetFloat("toggleOff") == 1f)
        {
            toggle.isOn = false;
        }

        if (PlayerPrefs.GetFloat("toggleOff") == 0f)
        {
            toggle.isOn = true;
        }
    }

    public void Update()
    {
        if (toggle.isOn == false)
        {
            AudioListener.volume = 0f;

            PlayerPrefs.SetFloat("toggleOff", 1f);
        }

        if (toggle.isOn == true)
        {
            AudioListener.volume = 1f;

            PlayerPrefs.SetFloat("toggleOff", 0f);
        }
    }
}
