
using UnityEngine;
using static Play;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    public GameObject car;

    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    void Update()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + (spawnDelay/traffic);
        }
    }

    void SpawnCar ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
