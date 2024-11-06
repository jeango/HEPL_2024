using System;
using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval;
    private float timer;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnInterval);
    }

    void Spawn()
    {
        Instantiate(objectToSpawn, transform.position, Quaternion.identity);
    }
}
