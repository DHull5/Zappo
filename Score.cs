using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour 
{
	public GameObject winPanel;
	public static int score;

	Text text;

	void Awake ()
	{
		winPanel.SetActive (false);
		text = GetComponent<Text>();
		score = 0;
	}

	// Update is called once per frame
	void Update () 
	{
		text.text = "Score: " + score;
		if(score >= 20)
		{
			winPanel.SetActive(true);
			Time.timeScale = 0;
		}
	}
}
