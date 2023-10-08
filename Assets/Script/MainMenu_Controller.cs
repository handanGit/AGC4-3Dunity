using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_Controller : MonoBehaviour
{
    public Button playBtn;
    public Button exitBtn;

    private void Start()
    {
        playBtn.onClick.AddListener(playGame);
        exitBtn.onClick.AddListener(exitGame);
    }
    private void playGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void exitGame()
    {
        Application.Quit();
    }
}
