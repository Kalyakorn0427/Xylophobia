using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;
    [SerializeField] public float playerSpeed = 5f;
    //[SerializeField] private float rotationSpeed;
    [SerializeField] private Camera followCamera;

    private Vector3 playerVelocity;
    [SerializeField] private float gravityValue = -13f;

    [SerializeField] public Animator animator;
    //[SerializeField] ChangeMap ChangeMap;

    public static PlayerMovement instance;
    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator.GetBool("win") != true)
        {
            Movement();
        }
        
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("BoxDamage"))
        {
            playerSpeed = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }*/

    void Movement()
    {
        

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementIput = Quaternion.Euler(0,followCamera.transform.eulerAngles.y,0) 
            * new Vector3(horizontalInput,0,verticalInput);

        Vector3 movementDirection = movementIput.normalized;

        controller.Move(movementDirection * playerSpeed * Time.deltaTime);


        animator.SetFloat("speed", Mathf.Abs(movementDirection.x) + Mathf.Abs(movementDirection.z));

        /*if (movementDirection != Vector3.zero) 
        {
            Quaternion desiredRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
        }*/

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
