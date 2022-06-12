using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class control_coins : MonoBehaviour
{
    public TextMeshProUGUI textCoins;

    // Start is called before the first frame update
    void Start()
    {
        textCoins = GameObject.FindWithTag("coinUI").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        textCoins.text = "- " + PlayerPrefs.GetInt("collectedCoins");
    }
}
