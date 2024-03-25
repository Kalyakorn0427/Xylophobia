using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVoice : MonoBehaviour
{
    [SerializeField] AudioSource Audio;
    [SerializeField] BoxCollider check;

    // Start is called before the first frame update
    void Start()
    {
        Audio.enabled = false;
        Audio.volume = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Audio.enabled = true;
        Audio.volume = 0.5f;

    }
}
