using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int a=5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Die()
    {
        GetComponent<Rigidbody>().isKinematic=false;


    }

    public void damage()
    {
        a=a-1;
        if(a<1)
        {
            Die();
        }
        


    }
}

