using UnityEngine;
using System.Collections;

public class RaiseLowerPlatform : MonoBehaviour 
{
	public Transform movingPlatform;
	public Transform pos1;
	public Transform pos2;
	public Vector3 newPos;
	public string currentState;
	public float smooth;
	public float resetTime;

	// Use this for initialization
	void Start () 
	{
		ChangeTarget ();	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPos, smooth * Time.deltaTime);
	}

	void ChangeTarget()
	{
		if(currentState == "Moving to Pos1")
		{
			currentState = "Moving to Pos2";
			newPos = pos2.position;
		}
		else if (currentState == "Moving to Pos2")
		{
			currentState = "Moving to Pos1";
			newPos = pos1.position;
		}
		else if (currentState == "")
		{
			currentState = "Moving to Pos2";
			newPos = pos2.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}
