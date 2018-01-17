using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DeathPanel : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void RestartGame()
	{
		Application.LoadLevel ("Level1");
	}
}
