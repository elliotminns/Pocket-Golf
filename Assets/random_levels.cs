using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class random_levels : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        PlayerPrefs.SetInt("endlessPlay", 1);

        string[] zones = new string[32] { "1-1", "1-2", "1-3", "1-4", "1-5", "1-6", "1-7", "1-8", "2-1", "2-2", "2-3", "2-4", "2-5", "2-6", "2-7", "2-8", "3-1", "3-2", "3-3", "3-4", "3-5", "3-6", "3-7", "3-8", "4-1", "4-2", "4-3", "4-4", "4-5", "4-6", "4-7", "4-8" };
        int random = Random.Range(0, 32);
        SceneManager.LoadScene(zones[random]);
    }
}
