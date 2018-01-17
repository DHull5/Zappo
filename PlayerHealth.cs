using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour 
{
	public GameObject deathPanel;
	public float currentHealth;
	public float startingHealth = 100;
	public Slider healthSlider;
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	bool damaged;
	
	void Awake ()
	{
		currentHealth = startingHealth;
		deathPanel.SetActive (false);
		//startingHealth = currentHealth;
		//healthSlider.value = 100;
	}

	void OnTriggerStay(Collider col)
	{
		if(col.gameObject.tag=="Enemy")
		{
			healthSlider.value -= 2;
		}

		if(col.gameObject.tag == "Enemy")
		{
			currentHealth -=2;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Checks if player has recieved damage
		//if (damaged)
		{
			//if player damaged flash colour
			//damageImage.color = flashColour;
		}
		//else
		{
			//change the colour back to clear
			//damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}	

		healthSlider.value = currentHealth;

		//if(healthSlider.value <= 0)
		if(currentHealth <= 0)
		{
			Destroy(gameObject);
			deathPanel.SetActive(true);
			Time.timeScale = 1;
		}
	}
}
