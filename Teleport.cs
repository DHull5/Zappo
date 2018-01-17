using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour 
{
	public Transform target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Teleport")
			gameObject.transform.position = target.transform.position;
			//this.transform.position = target.position;
	}
}
