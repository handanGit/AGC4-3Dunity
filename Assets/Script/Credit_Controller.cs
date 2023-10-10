using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credit_Controller : MonoBehaviour
{
    public Button backtoMMBtn;

    private void Start()
    {
        backtoMMBtn.onClick.AddListener(BacktoMM);
    }
    private void BacktoMM()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
