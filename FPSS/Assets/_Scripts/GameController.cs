using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject grenadeAmmo;
    public float grenadeDuration;
    public float grenadeRate;

	void Start()
    {
        InvokeRepeating("SpawnGrenadeAmmo", grenadeDuration, grenadeRate);
    }
	
	void Update()
    {
        
	}

    void SpawnGrenadeAmmo()
    {
        float RandomX = Random.Range(-20f, 20f);
        float GrenadeY = 0.2f;
        float RandomZ = Random.Range(-20f, 20f);
        Vector3 grenadePos = new Vector3(RandomX, GrenadeY, RandomZ);
        Instantiate(grenadeAmmo, grenadePos, Quaternion.identity);
    }
}
