using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMovement : MonoBehaviour 
{

	[SerializeField] Direction dir;  // this is the enumerator at the bottom
	[SerializeField] Transform target;  // the target you want to move  // the player

	[SerializeField] float speed = 125f;

	void OnMouseDown ()
	{
		Vector3 pos = target.position;  // variable
		
		// create a switch case statement
		switch (dir) 
		{
			case Direction.LEFT:
			pos += Vector3.left * Time.deltaTime * speed;
			break;

			case Direction.RIGHT:
			pos += Vector3.right * Time.deltaTime * speed;
			break;

			default:
			pos = Vector3.zero;
			break;
		}

		target.position = pos;    // updates the position ever

		


		Debug.Log ("button touched ");

	}
} // end class 

public enum Direction
{
	LEFT,
	RIGHT

}
