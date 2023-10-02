using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomIn_Controller : MonoBehaviour
{
    public Collider ball;
    public Camera_Controller cameraController;
    public float length;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            cameraController.FollowTarget(ball.transform, length);
        }
    }
}
