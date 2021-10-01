using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitOrExit : MonoBehaviour {
	public string NameScene = "Gameplay2";
	private void Update()
	{
		if (Input.GetKeyUp (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	private void OnTriggerEnter2D (Collider2D collision)
	{
		if (collision.tag.Equals ("Player")) {
			SceneManager.LoadScene ("Gameplay2");
		}
	}

	void Start () {
		
	}
}
	
