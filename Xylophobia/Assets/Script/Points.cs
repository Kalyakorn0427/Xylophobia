using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Points : MonoBehaviour
{
    public static int point = 0;

    public enum pointstate { state0, state1, state2, state3, state4, state5, state6 };
    public pointstate state;

    //public MeshRenderer circleRender;

    public ParticleSystem fire1;
    public ParticleSystem fire2;
    public ParticleSystem fire3;
    public ParticleSystem fire4;
    public ParticleSystem fire5;
    public ParticleSystem fire6;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public Light light5;
    public Light light6;

    float timeRemain = 0;


    // Start is called before the first frame update
    void Start()
    {
        //circleRender = GetComponent<MeshRenderer>();
        //circleRender.enabled = false; 

        fire1.Stop();
        fire2.Stop();
        fire3.Stop();
        fire4.Stop();
        fire5.Stop();
        fire6.Stop();

        light1.enabled = false;
        light2.enabled = false;
        light3.enabled = false;
        light4.enabled = false;
        light5.enabled = false;
        light6.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        pointCheck();

        firePlay();
    }
    
    private void pointCheck()
    {
        switch(point)
        {
            case 0:
                state = pointstate.state0; 
                break;
            case 1:
                state = pointstate.state1;
                break;
            case 2:
                state = pointstate.state2;
                break;
            case 3:
                state = pointstate.state3;
                break;
            case 4:
                state = pointstate.state4;
                break;
            case 5:
                state = pointstate.state5;
                break;
            case 6:
                state = pointstate.state6;
                break;
            case 7:
                state = pointstate.state6;
                break;
        }
    }

    private void firePlay()
    {
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
        }
        else if (timeRemain == 0)
        {
            timeRemain = 100;
            switch (state)
            {
                case pointstate.state1:
                    fire1.Play();

                    light1.enabled = true;
                    break;
                case pointstate.state2:
                    fire1.Play();
                    fire2.Play();

                    light1.enabled = true;
                    light2.enabled = true;
                    break;
                case pointstate.state3:
                    fire1.Play();
                    fire2.Play();
                    fire3.Play();

                    light1.enabled = true;
                    light2.enabled = true;
                    light3.enabled = true;
                    break;
                case pointstate.state4:
                    fire1.Play();
                    fire2.Play();
                    fire3.Play();
                    fire4.Play();

                    light1.enabled = true;
                    light2.enabled = true;
                    light3.enabled = true;
                    light4.enabled = true;
                    break;
                case pointstate.state5:
                    fire1.Play();
                    fire2.Play();
                    fire3.Play();
                    fire4.Play();
                    fire5.Play();

                    light1.enabled = true;
                    light2.enabled = true;
                    light3.enabled = true;
                    light4.enabled = true;
                    light5.enabled = true;
                    break;
                case pointstate.state6:
                    fire1.Play();
                    fire2.Play();
                    fire3.Play();
                    fire4.Play();
                    fire5.Play();
                    fire6.Play();
                    light1.enabled = true;
                    light2.enabled = true;
                    light3.enabled = true;
                    light4.enabled = true;
                    light5.enabled = true;
                    light6.enabled = true;
                    break;
                default:
                    fire1.Stop();
                    fire2.Stop();
                    fire3.Stop();
                    fire4.Stop();
                    fire5.Stop();
                    fire6.Stop();
                    light1.enabled = false;
                    light2.enabled = false;
                    light3.enabled = false;
                    light4.enabled = false;
                    light5.enabled = false;
                    light6.enabled = false;
                    break;
            }
        }
    }

}
