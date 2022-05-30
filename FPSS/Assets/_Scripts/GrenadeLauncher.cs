using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrenadeLauncher : MonoBehaviour {

    public GameObject grenade;
    public Transform grenadeSource;
    public int ammo = 3;
    public Text ammoText;

    void Start()
    {
        ammoText.text = ammo.ToString();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.G) && ammo > 0)
        {
            Instantiate(grenade, grenadeSource.position, grenadeSource.rotation);
            ammo--;
            ammoText.text = ammo.ToString();
            //grenade.GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            //grenade.GetComponent<Rigidbody>().AddForce(transform.up * 250);
            //print("GRENADE!!!!!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Ammo")
        {
            ammo += 1;
            ammoText.text = ammo.ToString();
            other.gameObject.SetActive(false);
        }
    }
}
