using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform PlayerBody;
    float MouseSensivity = 10;
    float xRotation = 0;
    // gg
    void Start()
    {
        
    }

    // chto zdes proishodit
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*MouseSensivity; 
        float mouseY = Input.GetAxis("Mouse Y") * MouseSensivity; 

        xRotation = xRotation - mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        PlayerBody.Rotate(Vector3.up * mouseX);
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if(hit.transform.gameObject.GetComponent<Enemy>()){
                     hit.transform.gameObject.GetComponent<Enemy>().damage();
                }
            }
        }

    }
}
