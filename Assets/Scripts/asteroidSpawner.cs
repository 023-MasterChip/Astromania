using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;


    public GameObject asteroid;

    public float spawnDelay;
    public float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawner", spawnDelay, spawnTime);
        InvokeRepeating("spawner2", spawnDelay, spawnTime);
    }



    void spawner()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(asteroid, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

}
