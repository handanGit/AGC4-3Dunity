using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_Controller : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider ball;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    public Score_Manager scoreManager;

    private SwitchState state;
    private Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        
        set(false);

        StartCoroutine(BlingTimerStart(5));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            toggle();
            Debug.Log("Switch triggered");
        }
    }

    private void set(bool active)
    {
        if (active == true)
        {
            state = SwitchState.On;
            renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            renderer.material = offMaterial;
            StartCoroutine(BlingTimerStart(5));
        }

        //Versi pendek if statement diatas
        //renderer.material = isOn ? onMaterial : offMaterial;
    }

    private void toggle()
    {
        if(state == SwitchState.On)
        {
            set(false);
        }
        else
        {
            set(true);
        }

        //add score
        scoreManager.AddScore(score);
    }
    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for(int i = 0; i < times; i++)
        {
            renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlingTimerStart(5));
        StartCoroutine(Blink(2));
    }

    private IEnumerator BlingTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
    }
}
