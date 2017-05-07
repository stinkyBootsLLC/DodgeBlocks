using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour 
{
	
	[SerializeField] float speed = 0.5f;
	[SerializeField] float mapWidth = 3.0f;

	private GameController gameController;

	private Rigidbody2D rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();  // assign the Objects rigid body 2d component to the varaiable rb
		gameController= FindObjectOfType<GameController>();  // assign the class GameController to variable gameController

	}
	
	void FixedUpdate () 
	{
		PlayerMovement ();

	}


	void PlayerMovement ()
	{
		// horizontal inputs
		float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

		Vector2 newPosition =  rb.position + Vector2.right * x;


		// limits the player movement to mapwidth defined above
		newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

		rb.MovePosition(newPosition);

//		#if UNITY_ANDROID
//		if (Input.touchCount == 1)
//		{
//			transform.Translate (Input.touches[0].deltaPosition.x * 1f, 0 , 0);
//		}
//
//		#endif

	}


	void OnCollisionEnter2D ()
	{
		//Debug.Log("player dead");

		gameController.EndGame();

	}










}
