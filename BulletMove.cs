using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
	public float speed;

	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody>().velocity = transform.right * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
