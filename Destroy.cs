using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour 
{	
	void Start ()
	{
		Destroy (gameObject, 1.5f);
	}

	void onCollisionEnter (Collision other)
	{
		//if (other.gameObject.tag == "Enemy") 
		{
			//Destroy (gameObject,1);
		}
	}
}
