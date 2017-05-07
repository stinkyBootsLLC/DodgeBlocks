using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour 
{
	private AudioSource gameOverAudio;
	
	void Start () 
	{
		// to make the blocks fall faster thru out time 

		// By increasing the gravity scale on the rigidbody2d component

		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;

		// get the audio source component

		gameOverAudio = gameObject.GetComponent<AudioSource>();
	}


	void Update () 
	{
		if (transform.position.y < -2f)
		{
			Destroy(this.gameObject);

			// if position of this gameObject is less than -2

			// then destroy this gameObjet
		}
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if (collision.collider.tag == "Player") 
		{    
			gameOverAudio.Play();

			// if the block hits the player
			// then play the audio component
		}
	}
} // end class
