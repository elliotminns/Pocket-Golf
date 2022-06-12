using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class is_muted : MonoBehaviour
{

    void Start()
    {
        if (PlayerPrefs.GetFloat("toggleOff") == 0)
        {
            AudioListener.volume = 1;
        }
        else if (PlayerPrefs.GetFloat("toggleOff") == 1)
        {
            AudioListener.volume = 0;
        }
        
    }
}
