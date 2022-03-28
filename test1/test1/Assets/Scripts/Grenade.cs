using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PS;
    void Start()
    {
        StartCoroutine(Blow(1));
    }
    IEnumerator Blow(int sec)
    {
        yield return new WaitForSeconds(sec);
        Debug.Log("Boom");
        GameObject blow=Instantiate(PS);
        blow.transform.position=transform.position;
        Destroy(this.gameObject);


    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
