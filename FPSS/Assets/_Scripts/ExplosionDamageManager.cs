using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamageManager : MonoBehaviour {

    public float explosionForce = 4;


    private IEnumerator Start()
    {
        // wait one frame because some explosions instantiate debris which should then
        // be pushed by physics force
        yield return null;

        float multiplier = 1; //GetComponent<ParticleSystemMultiplier>().multiplier;

        float r = 10 * multiplier;
        var cols = Physics.OverlapSphere(transform.position, r);
        var rigidbodies = new List<Rigidbody>();
        foreach (var col in cols)
        {
            EnemyHealth enemyHealth = col.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(1000000, Vector3.zero);
            }
        }
    }
}
