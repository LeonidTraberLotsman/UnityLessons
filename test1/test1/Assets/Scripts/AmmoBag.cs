using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBag : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {    
        Debug.Log("Col" + collision.transform.name);
        if(collision.transform.GetComponent<PlayerBodyMove>())
        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
