using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRamp_Controller : MonoBehaviour
{
    public float score;
    public Collider ball;

    public Score_Manager scoreManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            //add score
            scoreManager.AddScore(score);
        }
    }
}
