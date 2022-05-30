using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Transform player;   // player's position
    UnityEngine.AI.NavMeshAgent nav;    // component
    EnemyHealth enemyHealth;
    PlayerHealth playerHealth;
	void Start()
    {
        player = GameObject.Find("FPSController").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        enemyHealth = GetComponent<EnemyHealth>();
        playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	void Update()
    {
        if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
        {
            nav.SetDestination(player.position); // Move toward the player
        }
        else
        {
            nav.enabled = false;
        }
	}       
}
