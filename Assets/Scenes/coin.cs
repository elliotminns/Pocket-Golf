using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource audioData;

    public GameObject coinObj;

    public SpriteRenderer sr;

    public static int collectedCoins;

    private void Start()
    {
        collectedCoins = PlayerPrefs.GetInt("collectedCoins");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            collectedCoins++;

            coinObj.SetActive(false);
        }
    }

    public void Update()
    {
        /*
        if (on_enter.addCoins == true)
        {
            PlayerPrefs.SetInt("collectedCoins", collectedCoins);
        }
        */
    }
}
