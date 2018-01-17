using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyDestroy : MonoBehaviour 
{
	void OnTriggerEnter (Collider other) 
	{
		if (other.tag == "enemy") 
		{
			return;
		}

		Destroy (other.gameObject);
		Destroy (gameObject);
	}

}
