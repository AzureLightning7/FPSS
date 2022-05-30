using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;  // One static var
    Text scoreText; // reference to text object

	void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0; // starting game score
	}
	
	void Update()
    {
        scoreText.text = "Score: " + score;
	}
}
