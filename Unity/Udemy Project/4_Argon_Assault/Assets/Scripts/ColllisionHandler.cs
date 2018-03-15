using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColllisionHandler : MonoBehaviour {

    [Tooltip("Time between death and restarting the level")][SerializeField] float levelLoadDelay = 1f;
    [Tooltip("Special effects on death")] [SerializeField] GameObject deathFX;
   
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collider)
    {
        StartDeathSequence();
    }

    private void StartDeathSequence()
    {
        SendMessage("OnPlayerDeath");
        deathFX.SetActive(true);
        Invoke("RestartCurrentScene", levelLoadDelay);
    }

    private void RestartCurrentScene()
    {
        SceneManager.LoadScene(1);
    }
}
