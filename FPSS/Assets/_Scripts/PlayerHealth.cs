using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // For slider
using UnityEngine.SceneManagement; // for restart level
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public AudioClip deathClip;
    GameObject player;
    Animator anim;
    AudioSource playerAudio;
    //PlayerMovement playerMovement;
    bool isDead;
    FirstPersonController FPS;

	void Start()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        player = GameObject.FindGameObjectWithTag("Player");
        //playerMovement = GetComponent<PlayerMovement>();
        currentHealth = startingHealth;
        //player.SetActive(true);
        FPS = GetComponent<FirstPersonController>();
        FPS.enabled = true;
    }
	
	void Update()
    {
		
	}

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        healthSlider.value = currentHealth;

        playerAudio.Play();

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        //anim.SetTrigger("Die");

        playerAudio.clip = deathClip;
        playerAudio.Play();

        if (player != null)
        {
            EndLevel();
        }
    }

    public void EndLevel()
    {
        FPS.enabled = false;
        Invoke("RestartLevel", 5);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
