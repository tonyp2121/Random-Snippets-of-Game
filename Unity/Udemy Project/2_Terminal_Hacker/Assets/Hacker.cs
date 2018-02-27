using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    private int level = 0;

    enum Screen { mainMenu, password, win };
    Screen currentScreen;

	// Use this for initialization
	void Start () {
        showMainMenu();
    }
	
    void showMainMenu()
    {
        currentScreen = Screen.mainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Pick a difficulty level haxxor");
        Terminal.WriteLine("1 - Library");
        Terminal.WriteLine("2 - Police Station");
        //Terminal.WriteLine("3 - Nasa");
    }

    // Update is called once per frame
    void Update () {
		
	}

    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            showMainMenu();
        }
        else if (currentScreen == Screen.mainMenu)
        {
            RunMainMenu(input);
        }
    }

    private void RunMainMenu(string input)
    {
        if (input == "1" || input == "2")
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please pick a level from 1-3");
        }
    }

    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You've chosen level " + level);
        currentScreen = Screen.password;
    }
}
