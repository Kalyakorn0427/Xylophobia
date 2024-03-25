using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class GhostController : MonoBehaviour
{
    [SerializeField] Transform ghostposition;

    public NavMeshAgent agent;

    public Animator animator;
    public enum AIState
    {
        isDead, isIdle, isFollow, isAttack
    }
    AIState state;
    
    // Start is called before the first frame update
    void Start()
    {
        agent.stoppingDistance = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //print(state.ToString());

        float distanceToPlayer = Vector3.Distance(transform.position, PlayerMovement.instance.transform.position);

        if(distanceToPlayer >= 5.5f && distanceToPlayer <= 25f)
        {
            state = AIState.isFollow;
        }
        else if (distanceToPlayer > 25)
        {
            state = AIState.isIdle;
        }
        else
        {
            state = AIState.isAttack;
        }

        //print(distanceToPlayer);
        //print(agent.stoppingDistance);

        switch (state)
        {
            case AIState.isDead:
                agent.speed = 0;
                break;
            case AIState.isIdle:
                agent.speed = 0;
                agent.SetDestination(new Vector3(ghostposition.position.x, ghostposition.position.y, ghostposition.position.z));
                animator.SetBool("walk", false);
                animator.SetBool("attack", false);
                break;
            case AIState.isFollow:
                agent.speed = 3.5f;
                agent.SetDestination(PlayerMovement.instance.transform.position);
                animator.SetBool("walk", true);
                animator.SetBool("attack", false);
                break;
            case AIState.isAttack:
                RotateToPlayer();
                agent.stoppingDistance = 5f;
                agent.speed = 0;
                animator.SetBool("walk", false);
                animator.SetBool("attack", true);
                break;
        }
    }

    void RotateToPlayer()
    {
        Vector3 direction = (PlayerMovement.instance.transform.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation,lookRotation,Time.deltaTime * 5f);
    }
}
