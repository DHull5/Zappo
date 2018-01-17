using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour 
{
	public GameObject contPanel;

	public void controlPanel()
	{
		contPanel.SetActive(true);
	}

	public void onReturn()
	{
		contPanel.SetActive (false);
	}

	public void StartGame()
	{
		Application.LoadLevel("level1");
	}

	public void LeaveGame()
	{
		Application.LoadLevel("MainMenu");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

	public void Credits()
	{
		Application.LoadLevel("Credits");
	}
}
