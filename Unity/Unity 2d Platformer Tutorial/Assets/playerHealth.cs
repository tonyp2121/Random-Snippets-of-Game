using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerHealth : MonoBehaviour {

    public bool hasDied;
    public int health;

	// Use this for initialization
	void Start () {
        hasDied = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.transform.position.y < -7 && !hasDied)
        {
            hasDied = true;
        }
        if (hasDied){
            StartCoroutine("Die");
        }
	}

    IEnumerator Die ()
    {
        SceneManager.LoadScene("prototype area 1");
        yield return null;
    }
}
