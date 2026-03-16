using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public PauseMenu Pm;

    public Transform Camera;

    float xRotation = 0f;
    float yrotation = 0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yrotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yrotation, 0f);

    }

    void Start()
    {
        if (Pm.MousePause == false)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (Pm.MousePause == true)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}