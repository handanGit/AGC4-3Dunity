using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoomOut_Controller : MonoBehaviour
{
    public Collider ball;
    public Camera_Controller cameraController;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            cameraController.BackToDefault();
        }
    }
}
