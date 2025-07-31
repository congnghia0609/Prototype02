using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        // InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        SetRandomSpawnTime();
    }

    void Update()
    {
        spawnInterval -= Time.deltaTime;
        if (spawnInterval <= 0f)
        {
            SpawnRandomBall();
            SetRandomSpawnTime();
        }
    }

    void SetRandomSpawnTime()
    {
        spawnInterval = Random.Range(3f, 5f); // Random value between 3 and 5 seconds
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[0].transform.rotation);
    }

}
