using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{
	public Text counter;
	public float seconds;
	public float minutes;
	
	void Update () 
	{
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60F);
		counter.text = minutes.ToString("00") + ":" + seconds.ToString("00");
	}
}
