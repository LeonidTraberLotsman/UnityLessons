using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform PlayerBody;
    float MouseSensivity = 30;
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*MouseSensivity; 
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensivity; 

        xRotation = xRotation - mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        PlayerBody.Rotate(Vector3.up * mouseX);

    }
}
