using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level_position : MonoBehaviour
{
    public GameObject panel;

    int pref;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.Save();
        pref = PlayerPrefs.GetInt("Unlocked");

        if (pref == 0)
        {
            panel.transform.localPosition = new Vector3(0, -989, 0);
        }
        if (pref == 1)
        {
            panel.transform.localPosition = new Vector3(0, -463, 0);
        }
        if (pref == 2)
        {
            panel.transform.localPosition = new Vector3(0, 78, 0);
        }
        if (pref == 3)
        {
            panel.transform.localPosition = new Vector3(0, 640, 0);
        }
        if(pref == 4)
        {
            panel.transform.localPosition = new Vector3(0, 989, 0);
        }
    }
}
