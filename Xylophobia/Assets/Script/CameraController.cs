using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float mouseSensitivity = 3.0f;

    private float rotationY;
    private float rotationX;

    [SerializeField] private Transform target;
    [SerializeField] private float distanceFromTarget = 0f;

    private Vector3 currentRotation;
    private Vector3 smoothVelocity =Vector3.zero;

    [SerializeField] private float smoothTime = 0.2f;
    [SerializeField] private Vector2 rotationMinMax = new Vector2(-40, 60);
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        currentRotation = new Vector3(0, 90, 0);

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY += mouseX;
        rotationX += mouseY;

        rotationX = Mathf.Clamp(rotationX, rotationMinMax.x, rotationMinMax.y);

        Vector3 nextRotation = new Vector3(rotationX, rotationY + 90);

        currentRotation = Vector3.SmoothDamp(currentRotation, nextRotation, ref smoothVelocity, smoothTime);
        transform.localEulerAngles = currentRotation;

        transform.position = target.position;

    }
}
