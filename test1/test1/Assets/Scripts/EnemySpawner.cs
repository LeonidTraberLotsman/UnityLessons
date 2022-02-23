using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }


    public IEnumerator Spawn()
        {
            while(true)
            {
                GameObject Clone = Instantiate(prefab);
                Clone.transform.position = transform.position;

                yield return new WaitForSeconds(3);
            }

        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
