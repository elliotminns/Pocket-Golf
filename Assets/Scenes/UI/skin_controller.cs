using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class skin_controller : MonoBehaviour
{
    public TextMeshProUGUI smileCoins;
    public TextMeshProUGUI robotCoins;
    public TextMeshProUGUI planetCoins;
    public TextMeshProUGUI bballCoins;
    public TextMeshProUGUI eyeCoins;

    public GameObject equippedBall;
    public GameObject equippedSmile;
    public GameObject equippedRobot;
    public GameObject equippedPlanet;
    public GameObject equippedBBall;
    public GameObject equippedEye;

    public GameObject error;

    public AudioSource audioData;
    public AudioClip coin;
    public AudioClip equip;

    public GameObject ball;
    public GameObject smile;
    public GameObject robot;
    public GameObject planet;
    public GameObject bBall;
    public GameObject eye;

    public GameObject equipSmile;
    public GameObject equipRobot;
    public GameObject equipPlanet;
    public GameObject equipBBall;
    public GameObject equipEye;

    public void Start()
    {

        if (PlayerPrefs.GetInt("purchasedSmile") == 1)
        {
            smile.SetActive(false);
            equipSmile.SetActive(true);

            smileCoins.text = "Smile";
        }
        if (PlayerPrefs.GetInt("purchasedRobot") == 1)
        {
            robot.SetActive(false);
            equipRobot.SetActive(true);

            robotCoins.text = "Robot";
        }
        if (PlayerPrefs.GetInt("purchasedPlanet") == 1)
        {
            planet.SetActive(false);
            equipPlanet.SetActive(true);

            planetCoins.text = "planet";
        }
        if (PlayerPrefs.GetInt("purchasedBBall") == 1)
        {
            bBall.SetActive(false);
            equipBBall.SetActive(true);

            bballCoins.text = "Basket Ball";
        }
        if (PlayerPrefs.GetInt("purchasedEye") == 1)
        {
            eye.SetActive(false);
            equipEye.SetActive(true);

            eyeCoins.text = "Eye";
        }
    }

    public void smileBuy()
    {
        if (PlayerPrefs.GetInt("collectedCoins") >= 20)
        {
            PlayerPrefs.SetInt("ballSkin", 1);
            PlayerPrefs.SetInt("collectedCoins", PlayerPrefs.GetInt("collectedCoins") - 20);
            audioData.PlayOneShot(coin, 0.1f);
            PlayerPrefs.SetInt("purchasedSmile", 1);

            smile.SetActive(false);
            equipSmile.SetActive(true);
            smileCoins.text = "Smile";
        }
        else
        {
            error.SetActive(true);
            audioData.PlayOneShot(equip, 1f);
        }
    }

    public void robotBuy()
    {
        if (PlayerPrefs.GetInt("collectedCoins") >= 40)
        {
            PlayerPrefs.SetInt("ballSkin", 2);
            PlayerPrefs.SetInt("collectedCoins", PlayerPrefs.GetInt("collectedCoins") - 40);
            audioData.PlayOneShot(coin, 0.1f);
            PlayerPrefs.SetInt("purchasedRobot", 1);

            robot.SetActive(false);
            equipRobot.SetActive(true);
            robotCoins.text = "Robot";
        }
        else
        {
            error.SetActive(true);
            audioData.PlayOneShot(equip, 1f);
        }
    }

    public void planetBuy()
    {
        if (PlayerPrefs.GetInt("collectedCoins") >= 60)
        {
            PlayerPrefs.SetInt("ballSkin", 3);
            PlayerPrefs.SetInt("collectedCoins", PlayerPrefs.GetInt("collectedCoins") - 60);
            audioData.PlayOneShot(coin, 0.1f);
            PlayerPrefs.SetInt("purchasedPlanet", 1);

            planet.SetActive(false);
            equipPlanet.SetActive(true);
            planetCoins.text = "planet";
        }
        else
        {
            error.SetActive(true);
            audioData.PlayOneShot(equip, 1f);
        }
    }

    public void bBallBuy()
    {
        if (PlayerPrefs.GetInt("collectedCoins") >= 80)
        {
            PlayerPrefs.SetInt("ballSkin", 4);
            PlayerPrefs.SetInt("collectedCoins", PlayerPrefs.GetInt("collectedCoins") - 80);
            audioData.PlayOneShot(coin, 0.1f);
            PlayerPrefs.SetInt("purchasedBBall", 1);

            bBall.SetActive(false);
            equipBBall.SetActive(true);
            bballCoins.text = "Basket Ball";
        }
        else
        {
            error.SetActive(true);
            audioData.PlayOneShot(equip, 1f);
        }
    }

    public void eyeBuy()
    {
        if (PlayerPrefs.GetInt("collectedCoins") >= 200)
        {
            PlayerPrefs.SetInt("ballSkin", 5);
            PlayerPrefs.SetInt("collectedCoins", PlayerPrefs.GetInt("collectedCoins") - 200);
            audioData.PlayOneShot(coin, 0.1f);
            PlayerPrefs.SetInt("purchasedEye", 1);

            eye.SetActive(false);
            equipEye.SetActive(true);
            eyeCoins.text = "Eye";
        }
        else
        {
            error.SetActive(true);
            audioData.PlayOneShot(equip, 1f);
        }
    }

    public void ballEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 0);
        audioData.PlayOneShot(equip, 1f);
    }

    public void smileEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 1);
        audioData.PlayOneShot(equip, 1f);
    }

    public void robotEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 2);
        audioData.PlayOneShot(equip, 1f);
    }

    public void planetEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 3);
        audioData.PlayOneShot(equip, 1f);
    }

    public void bBallEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 4);
        audioData.PlayOneShot(equip, 1f);
    }

    public void eyeEquip()
    {
        PlayerPrefs.SetInt("ballSkin", 5);
        audioData.PlayOneShot(equip, 1f);
    }

    public void cancelError()
    {
        error.SetActive(false);
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("ballSkin") == 0)
        {
            equippedBall.SetActive(true);
            equippedSmile.SetActive(false);
            equippedRobot.SetActive(false);
            equippedPlanet.SetActive(false);
            equippedBBall.SetActive(false);
            equippedEye.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("ballSkin") == 1)
        {
            equippedBall.SetActive(false);
            equippedSmile.SetActive(true);
            equippedRobot.SetActive(false);
            equippedPlanet.SetActive(false);
            equippedBBall.SetActive(false);
            equippedEye.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("ballSkin") == 2)
        {
            equippedBall.SetActive(false);
            equippedSmile.SetActive(false);
            equippedRobot.SetActive(true);
            equippedPlanet.SetActive(false);
            equippedBBall.SetActive(false);
            equippedEye.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("ballSkin") == 3)
        {
            equippedBall.SetActive(false);
            equippedSmile.SetActive(false);
            equippedRobot.SetActive(false);
            equippedPlanet.SetActive(true);
            equippedBBall.SetActive(false);
            equippedEye.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("ballSkin") == 4)
        {
            equippedBall.SetActive(false);
            equippedSmile.SetActive(false);
            equippedRobot.SetActive(false);
            equippedPlanet.SetActive(false);
            equippedBBall.SetActive(true);
            equippedEye.SetActive(false);
        }

        else if (PlayerPrefs.GetInt("ballSkin") == 5)
        {
            equippedBall.SetActive(false);
            equippedSmile.SetActive(false);
            equippedRobot.SetActive(false);
            equippedPlanet.SetActive(false);
            equippedBBall.SetActive(false);
            equippedEye.SetActive(true);
        }
    }
}
