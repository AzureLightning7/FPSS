using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeController : MonoBehaviour {

    public GameObject explosion;
    public float grenadeTimer;
    public float speed;
    public float explosionDelay;
    public float explodeLifeTime;
    private Rigidbody rb;

	void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
        Invoke("Explode", explosionDelay);
	}

    void Update()
    {
        
    }

    void Explode()
    {
        GameObject myExplode =Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(myExplode, explodeLifeTime);
        Destroy(gameObject);
    }
}
