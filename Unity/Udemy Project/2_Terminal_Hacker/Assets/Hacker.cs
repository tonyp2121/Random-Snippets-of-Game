using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        showMainMenu()
    }
	
    void showMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello Haxxors, pick a difficulty level");
        Terminal.WriteLine("1 - Library");
        Terminal.WriteLine("2 - Police Station");
        //Terminal.WriteLine("3 - Nasa");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
