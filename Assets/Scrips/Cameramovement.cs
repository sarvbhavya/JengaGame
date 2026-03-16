using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform Camera;

    float xRotation = 0f;
    float yrotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        yrotation += mouseX;

        transform.localRotation = Quaternion.Euler(xRotation, yrotation, 0f);


    }
}
