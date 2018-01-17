using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AIMovement : MonoBehaviour 
{
	public float distance;
	public Transform target;
	public float rotation;
	public float view = 25.0f;
	public float attackPlayer = 20.0f;
	public float movementSpeed = 5.0f;
	public float smooth = 6.0f;

	// Update is called once per frame
	void Update () 
	{
		distance = Vector3.Distance (target.position, transform.position);

		if(distance < view)
		{
			//renderer.material.color = Color.yellow;
			lookAt();
		}

		if(distance > view)
		{
			//renderer.material.color = Color.green;
		}

		if(distance < attackPlayer)
		{
			//renderer.material.color = Color.red;
			attack();
		}
	}

	void lookAt()
	{
		Quaternion rotation = Quaternion.LookRotation(target.position - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * smooth);
	}	

	void attack ()
	{
		transform.Translate (Vector3.forward * movementSpeed * Time.deltaTime);
	}
}
