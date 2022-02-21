using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform Head;
    public Transform player;
    NavMeshAgent    agent;
    int a=5;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
    if(a>0){
        agent.destination=player.position;
    }
    
        
    }
    
    public void Die()
    {
        agent.enabled=false;
        Head.GetComponent<Rigidbody>().isKinematic=false;
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

