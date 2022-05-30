using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public PlayerHealth playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f; // delay for enemy spawn
    public Transform[] spawnPoints; // List of transform spawn locations

	void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
	}
	
	void Spawn()
    {
		if (playerHealth.currentHealth <= 0f) // player dead?
        {
            return; // then do nothing
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length); // random location

        Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}
