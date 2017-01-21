using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// When called exits the application
    /// </summary>
    public void ExitApllication()
    {
        Application.Quit();
    }

    /// <summary>
    /// Navigates to the Credits screen
    /// </summary>
    public void CreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }

    /// <summary>
    /// Navigates to the main play scene
    /// </summary>
    public void PlayClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
