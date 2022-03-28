using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
<<<<<<< HEAD
    // Start is called before the first frame update
    public GameObject PS;
    void Start()
    {
        StartCoroutine(Blow(1));
    }
=======
    public GameObject PS;

>>>>>>> 9e7d8a8144df3ee75f654b045c903c5bd4e9dd23
    IEnumerator Blow(int sec)
    {
        yield return new WaitForSeconds(sec);
        Debug.Log("Boom");
<<<<<<< HEAD
        GameObject blow=Instantiate(PS);
        blow.transform.position=transform.position;
        Destroy(this.gameObject);


    }
=======
        GameObject blow = Instantiate(PS);
        blow.transform.position=transform.position;
        Destroy(this.gameObject);
        
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Blow(1));
    }



>>>>>>> 9e7d8a8144df3ee75f654b045c903c5bd4e9dd23
    // Update is called once per frame
    void Update()
    {
        
    }
}
