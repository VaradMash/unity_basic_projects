using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawn_x_Range = 10.0f;
    private float spawn_z_position = 20.0f;
    private float start_delay = 2.0f;
    private float spawn_interval = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn_random_animal", start_delay, spawn_interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn_random_animal()
    {
        int index = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPosition = new Vector3(Random.Range(-spawn_x_Range, spawn_x_Range), 0, spawn_z_position);
        Instantiate(animalPrefabs[index], spawnPosition, animalPrefabs[index].transform.rotation);
    }

}
