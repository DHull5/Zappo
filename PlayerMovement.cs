using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
	public float playerSpeed = 5.0f;
	public float playerJump = 10.0f;
	public float gravity = 20.0f;

	private Vector3 moveDirection = Vector3.zero;
	
	void Update ()
	{

		CharacterController controller = GetComponent<CharacterController> ();
		if(controller.isGrounded)
		{
			moveDirection = new Vector3(Input.GetAxis("Horizontal"),0,0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= playerSpeed;

			if(Input.GetButtonDown("Jump"))
				moveDirection.y = playerJump;
		}
		
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move (moveDirection * Time.deltaTime);
	}
}