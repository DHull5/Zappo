using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour 
{
	public GameObject deathPanel;

	// Use this for initialization
	void Start () 
	{
		deathPanel.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other)
	{
		print ("Hit");
		if(other.gameObject.tag == "Player")
		{
			deathPanel.SetActive(true);
			Destroy(other.gameObject);
			//Application.LoadLevel("Level1");
		}
	}
}
