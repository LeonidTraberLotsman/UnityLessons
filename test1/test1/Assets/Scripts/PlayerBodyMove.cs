using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBodyMove : MonoBehaviour
{
    public float speed=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            
            transform.position = transform.position + speed*transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position = transform.position - speed * transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position = transform.position + speed * transform.right;
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position = transform.position - speed * transform.right;
        }
    }
}
