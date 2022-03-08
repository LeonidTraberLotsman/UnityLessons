using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject PS;

    IEnumerator Blow(int sec)
    {
        yield return new WaitForSeconds(sec);
        Debug.Log("Boom");
        GameObject blow = Instantiate(PS);
        blow.transform.position=transform.position;
        Destroy(this.gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blow(1));
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
