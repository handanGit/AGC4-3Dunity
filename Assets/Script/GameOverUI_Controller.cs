using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUI_Controller : MonoBehaviour
{
    public Button mainMenuBtn;

    private void Start()
    {
        mainMenuBtn.onClick.AddListener(MainMenu);
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
