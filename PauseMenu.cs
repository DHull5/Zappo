using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PauseMenu : MonoBehaviour 
{
	public GameObject pauseButton;
	public GameObject pausePanel;

	void Pause()
	{
		pausePanel.SetActive (true);
		pauseButton.SetActive (false);
		Time.timeScale = 0;
	}

	void UnPause()
	{
		pausePanel.SetActive (false);
		pauseButton.SetActive (true);
		Time.timeScale = 1;
	}


	void QuitGame()
	{
		Application.LoadLevel("MainMenu");
		Time.timeScale = 1;
	}
}
