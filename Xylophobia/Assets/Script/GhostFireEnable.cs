using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostFireEnable : MonoBehaviour
{
    public ParticleSystem ghost1;
    public ParticleSystem ghost2;
    public ParticleSystem ghost3;
    public ParticleSystem ghost4;

    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;

    float timeRemain = 0;
    // Start is called before the first frame update
    void Start()
    {
        ghost1.Play();
        ghost2.Stop();
        ghost3.Stop();
        ghost4.Stop();

        light1.enabled = true;
        light2.enabled = false;
        light3.enabled = false;
        light4.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ghostCheck();
    }

    private void ghostCheck()
    {
        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;
        }
        else
        {
            if (CheckPlayer.map == 4)
            {
                ghost1.Play();
                ghost2.Play();
                ghost3.Play();
                ghost4.Play();

                light1.enabled = true;
                light2.enabled = true;
                light3.enabled = true;
                light4.enabled = true;
            }
            else if (CheckPlayer.map == 6)
            {
                ghost1.Stop();
                ghost2.Stop();
                ghost3.Stop();
                ghost4.Stop();

                light1.enabled = false;
                light2.enabled = false;
                light3.enabled = false;
                light4.enabled = false;
            }
            else
            {
                ghost1.Play();
                ghost2.Stop();
                ghost3.Stop();
                ghost4.Stop();

                light1.enabled = true;
                light2.enabled = false;
                light3.enabled = false;
                light4.enabled = false;
            }
        
        }
    }
}
