using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform player;
    public Enemymanandger manager;
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
                Clone.GetComponent<Enemy>().player = player;
                manager.enemies.Add(Clone.GetComponent<Enemy>());
                yield return new WaitForSeconds(6);
            }

        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
