using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public float spawnInterval;
    public float maxOffset = 4.5f;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnInterval);
    }

    void Spawn()
    {
        var offset = new Vector3();
        offset.y = Random.Range(-maxOffset, maxOffset);
        Instantiate(objectToSpawn, transform.position + offset, Quaternion.identity);
    }
}
