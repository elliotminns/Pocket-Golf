using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class unhide_prefs : MonoBehaviour
{

    public Button clearButton;
    public Button yesButton;
    public Button cancelButton;

    public GameObject clearConfirm;

    private void OnEnable()
    {
        clearButton.onClick.AddListener(Clear);

        cancelButton.onClick.AddListener(Cancel);

        yesButton.onClick.AddListener(DeletePrefs);
    }
    void Clear()
    {
        clearConfirm.SetActive(true);
    }

    void Cancel()
    {
        clearConfirm.SetActive(false);
    }

    void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
        clearConfirm.SetActive(false);
        SceneManager.LoadScene("Index");
    }
}
