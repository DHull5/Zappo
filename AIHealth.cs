using UnityEngine;
using System.Collections;

public class AIHealth : MonoBehaviour 
{
	public float currentHealth;
	public int maxHealth = 100;
	public int minHealth = 0;
	public int scoreValue = 1;

	public AudioClip destroy;

	// Use this for initialization
	void Start () 
	{
		//sets player health at max
		currentHealth = maxHealth;
	}

	void Update ()
	{
		if(currentHealth <= 0)
		{
			currentHealth = 0;
		}

		if(currentHealth >= maxHealth)
		{
			currentHealth = maxHealth;
		}

		if(currentHealth <= 49)
		{
			currentHealth = minHealth;
		}
		
		if(currentHealth == minHealth)
		{
			Score.score += scoreValue;
			Destroy(gameObject, 0);
			GetComponent<AudioSource>().Play();
		}
	}

	//inflict damage to the player
	void OnTriggerEnter(Collider col)
	{
		if(col.gameObject.tag == "Bullets")
		{
			currentHealth -= 50;
		}
	}
}
