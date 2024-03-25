using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] PlayerMovement speed;
    
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("FadeWin");
            speed.playerSpeed = 0;
            speed.animator.SetFloat("speed", 0f);
            speed.animator.SetBool("win", true);


        }
    }
}
