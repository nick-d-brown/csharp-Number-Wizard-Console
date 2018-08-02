using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Global Variables declared here so they can be accessed by all methods
    int max;
    int min;
    int guess;

    // Use this for initialization (i.e. when the script is run and the app is started)
	void Start () 
    {
        
        // Start Method Variable Scope
        string charName = "Merlin";


        // Opening text only when game is started up
        Debug.Log("Welcome to Number Wizard!");
        Debug.Log("My name is " + charName + ", and I will be your number guessing magician.");

        // Starts the new game text
        StartGame();

	}

    // Method is used for game start or every time enter is hit
    void StartGame() 
    {
        max = 1000;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Please Pick a number between the highest and lowest number allowed.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Enter button = correct!");
        max = max + 1;
    }
	
	// Update is called once per frame
	void Update () 
    {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Too low I see...");
                min = guess;
                NextGuess();
            }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("So I need to guess lower, hmmmm...");
                max = guess;
                NextGuess();
            }
        else if(Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("HAZAAHHH! I Guessed Correctly");
                StartGame();
            }
        // No need for else right now because we aren't accounting for a base case
        //   and might add other buton options in later

	}

    void NextGuess() 
    {
        guess = (max + min) / 2;
        Debug.Log("My new guess is...   " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Enter button = correct!");
    }

}
