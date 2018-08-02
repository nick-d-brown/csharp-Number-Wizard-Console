using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    // Global Variables declared here so they can be accessed by all methods
    int max = 1000;
    int min = 1;
    int guess;

    // Use this for initialization (i.e. when the script is run and the app is started)
	void Start () {
        
        // Start Method Variable Scope
        string charName = "Merlin";
        guess = (max + min) / 2;

        // Logs to the console and gives more flexibility
        Debug.Log("Welcome to Number Wizard!");
        // Can use print, but not as common or as useful
        Debug.Log("My name is " + charName);

        Debug.Log("Please Pick a number between the highest and lowest number allowed.");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess + ".");
        Debug.Log("Push Up = higher, Push Down = lower, Enter button = correct!");

	}
	
	// Update is called once per frame
	void Update () {
        //Detect when the up arrow key is pressed down
        if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Debug.Log("Up Arrow key was pressed. Too low I see...");
                min = guess;
                Debug.Log("My new guess is...   " + guess);
                Debug.Log("Push Up = higher, Push Down = lower, Enter button = correct!");
            }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Debug.Log("Up Down key was pressed. So I need to guess lower, hmmmm...");
                max = guess;
                Debug.Log("My new guess is...   " + guess);
                Debug.Log("Push Up = higher, Push Down = lower, Enter button = correct!");
            }
        else if(Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("Enter key was pressed.");
                Debug.Log("HAZAAHHH!");
            }
        // No need for else right now because we aren't accounting for a base case
        //   and might add other buton options in later

	}
}
