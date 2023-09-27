using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher_Controller : MonoBehaviour
{
    public Collider ball;
    public KeyCode input;

    public float maxForce;
    public float maxTimeHold;

    public Material offMaterial;
    public Material onMaterial;

    private bool isHold = false;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == ball)
        {
            ReadInput(ball);
        }
    }

    void ReadInput(Collider collider)
    {
        if (Input.GetKey(input))
        {
            StartCoroutine(StartHold(collider));
            renderer.material = onMaterial;
        }
        else
        {
            renderer.material = offMaterial;
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;

            renderer.material = offMaterial;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
        
    }
}
