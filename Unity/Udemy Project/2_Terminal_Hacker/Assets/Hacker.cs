using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    private int rand;
    private int level;
    private string [,] password = { { "books", "aisle", "shelf", "password", "font", "borrow" }, 
                                    { "prisoner", "handcuffs", "holster", "uniform", "arrest", "sheriff"},
                                    { "starfield", "spaceman", "jupiter", "astronaut", "starship", "asteroid",} };

    enum Screen { mainMenu, password, win };
    private Screen currentScreen;

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
        Terminal.WriteLine("3 - Nasa");
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
        else if (currentScreen == Screen.password)
        {
            RunPasswordState(input);
        }
    }


    void StartGame()
    {
        rand = Random.Range(0, 6);
        print(password[level - 1, rand]);
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password");
        Terminal.WriteLine("Hint: " + password[level - 1, rand].Anagram());
        menuHint();
        currentScreen = Screen.password;
    }

    private void RunMainMenu(string input)
    {
        if (input == "1" || input == "2" || input == "3")
        {
            level = int.Parse(input);
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please pick a level from 1-3");
        }
    }

    private void RunPasswordState(string input)
    {
        if (input == password [level-1, rand])
        {
            currentScreen = Screen.win;
            Terminal.WriteLine("");
            Terminal.WriteLine("Correct Password");
            Terminal.WriteLine("YOU WIN!");
            menuHint();
        }
        else
        {
            StartGame();
        }
    }

    void menuHint()
    {
        Terminal.WriteLine("");
        Terminal.WriteLine("Type menu to return");
    }
}
