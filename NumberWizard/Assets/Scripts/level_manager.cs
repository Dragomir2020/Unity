﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level_manager : MonoBehaviour {

	public void LoadLevel(string name){
		SceneManager.LoadScene (name);
	}

	public void QuitGame(){
		Application.Quit ();
	}
}
