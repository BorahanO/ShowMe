using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private GameObject objectToSpawn;
    [SerializeField] private float spawnInterval; // Time interval between spawns
    private float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            float spawnX = transform.position.x;
            float spawnY = transform.position.y;
            Instantiate(objectToSpawn, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
            nextSpawnTime = Time.time + spawnInterval;
        }
    }
}