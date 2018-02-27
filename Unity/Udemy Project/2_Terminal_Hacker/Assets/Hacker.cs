using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    private int rand;
    private int level = 0;
    private string [,] password = { { "books", "aisle", "self", "password", "font", "borrow" }, 
                                    { "prisoner", "handcuffs", "holster", "uniform", "arrest", "sheriff"}};

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
        else if (currentScreen == Screen.password)
        {
            RunPasswordState(input);
        }
    }


    void StartGame()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Enter your password");
        Terminal.WriteLine("Hint: " + password[level - 1, rand].Anagram());
        currentScreen = Screen.password;
    }

    private void RunMainMenu(string input)
    {
        if (input == "1" || input == "2")
        {
            rand = Random.Range(0,6);
            level = int.Parse(input);
            print(password[level - 1, rand]);
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
        }
        else
        {
            StartGame();
        }
    }

}
