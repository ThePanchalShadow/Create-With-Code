using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //this will store all animals prefabs
    public GameObject[] animalPrefabs;
    float SpawnX = 15;
    float SpawnZ = 20;
    float start = 2;
    float Interval = 1.5f;

    void SpawnRandomAnimal()
    {
        //this will help select random animals
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //this will help spawn animals at random location
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnX, SpawnX), 0, SpawnZ);
        //this will spawn the animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", start, Interval);
    }
}
