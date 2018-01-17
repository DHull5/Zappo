using UnityEngine;
using System.Collections;

public class PlayerStay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//When player makes contact with Object
	//Object becomes the parent
	//So holds the player in place
	//Rather than allowing the player to fall through
	void OnTriggerEnter(Collider col)
	{
		col.transform.parent = gameObject.transform;
	}

	//When player leaves collider
	//Is free to move
	//No longer has parent object
	void OnTriggerExit(Collider col)
	{
		col.transform.parent = null;
	}
}
