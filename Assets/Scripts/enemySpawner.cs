using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    
    public GameObject enemy;

    public float spawnDelay;
    public float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", spawnDelay, spawnTime);
    }

    

    void spawner()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
    
}
