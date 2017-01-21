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


    public void ExitApllication()
    {
        Application.Quit();
    }

    public void CreditsClick()
    {
        SceneManager.LoadScene("Credits");
    }

    public void PlayClick()
    {
        SceneManager.LoadScene("MainScene");
    }
}
