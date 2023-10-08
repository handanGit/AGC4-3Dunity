using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver_Controller : MonoBehaviour
{
    public Collider ball;
    public GameOverUI_Controller gameOverUIController;
    public GameObject gameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}
