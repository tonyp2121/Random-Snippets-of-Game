using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    void Awake()
    {
        if (FindObjectsOfType<MusicPlayer>().Length > 1) { Destroy(gameObject);}
        DontDestroyOnLoad(transform.gameObject);
    }

	// Use this for initialization
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
