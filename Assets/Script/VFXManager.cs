using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{

    public GameObject bumperVFX;

    public void playVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(bumperVFX, spawnPosition, Quaternion.identity);
    }
}
