using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Only allow the player to spawn a new dog after a certain amount of time has passed
    private float spawnCooldown = 1.0f;
    private float nextSpawnTime;

    void Start() {
        nextSpawnTime = Time.time; // Allow spawn immediately at start
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        // Only allow the player to spawn a new dog after a certain amount of time has passed
        if (Input.GetKeyDown(KeyCode.Space) && Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextSpawnTime = Time.time + spawnCooldown;
        }
    }
}
