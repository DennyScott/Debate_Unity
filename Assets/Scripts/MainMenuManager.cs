using UnityEngine;
using System.Collections;

public class MainMenuManager : MonoBehaviour {
	//Starts the actia; game
	public void StartGame() {
		Application.LoadLevel("Selection");
	}	
}
