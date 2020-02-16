using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookWithMouse : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    public float mouseSensitivity = 100;
    private float xRotation = 0f;
    private float yRotation = 0f;
    public Transform ball;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        
        xRotation -= mouseY;
        yRotation += mouseX;//needed so you can look left and right

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);

        ball.Rotate(Vector3.up * mouseX);
    }
}
