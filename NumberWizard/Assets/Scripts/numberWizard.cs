using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class numberWizard : MonoBehaviour {

    private int min;
    private int max;
    private int guess;
	public Text TextGuess;
	private int maxNumberOfGuesses;

    // Use this for initialization
    void Start() {
        StartGame(); 
	}

	public void SetMaxGuess(int num){
		maxNumberOfGuesses = num;
	}

    private void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
		//Only valid for numbers 1-1000 or medium difficulty
		maxNumberOfGuesses = 9; 
        max += 1;
    }

	public void Higher(){
		min = guess;
		NextGuess();
	}

	public void Lower(){
		max = guess;
		NextGuess();
	}



    private void NextGuess()
    {
        guess = (max + min) / 2;
		TextGuess.text = guess.ToString();
		maxNumberOfGuesses--;
		if(maxNumberOfGuesses <= 0)
		{
			SceneManager.LoadScene ("Win");
		}
    }
}
