using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreUI_Controller : MonoBehaviour
{
    public TMP_Text scoreText;

    public Score_Manager scoreManager;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
