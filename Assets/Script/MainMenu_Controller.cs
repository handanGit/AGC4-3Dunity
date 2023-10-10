using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu_Controller : MonoBehaviour
{
    public Button playBtn;
    public Button exitBtn;
    public Button creditBtn;

    private void Start()
    {
        playBtn.onClick.AddListener(playGame);
        exitBtn.onClick.AddListener(exitGame);
        creditBtn.onClick.AddListener(OpenCredit);
    }
    private void playGame()
    {
        SceneManager.LoadScene("Pinball_Game");
    }

    private void OpenCredit()
    {
        SceneManager.LoadScene("Credit");
    }


    private void exitGame()
    {
        Application.Quit();
    }
}
