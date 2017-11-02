using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numberWizard : MonoBehaviour {

    private int min;
    private int max;
    private int guess;

    // Use this for initialization
    void Start() {
        StartGame(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I have won!");
            StartGame();
        }
        else
        {
            //Nothing Pressed or command not mapped
        }
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
       
        print("========================");
        print("Welcome to Number Wizard");
        print("Pick a number in your head, but don't tell me!");
        print("The highest number you can pick " + max + "!");
        print("The lowest number you can pick is " + min + "!");
        print("Is the number higher or lower than " + guess + "?");
        max += 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higher or lower than " + guess + "?");
        print("Up arrow for higher, down for lower and return for equal.");
    }
}
