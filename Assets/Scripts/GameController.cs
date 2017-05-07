using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour 
{
	[SerializeField] float slowMotionEffect = 30f;


	public void EndGame ()
	{
		//Debug.Log("game is over");

		StartCoroutine(RestartLevel());

	
	}


	IEnumerator RestartLevel ()   
	{

		// the matrix effect 

		Time.timeScale = 1f / slowMotionEffect;

		// if you adj time.timescale you also have to adjust fixed update

		Time.fixedDeltaTime = Time.fixedDeltaTime / slowMotionEffect;

		// before waitForSeconds

		yield return new WaitForSeconds (2f / slowMotionEffect);    // <-- delay this number to wait for sound effect 
																    // see Block.cs

		// after wait

		// set time back to normal

		Time.timeScale = 1f;

		Time.fixedDeltaTime = Time.fixedDeltaTime * slowMotionEffect;

		// load scene

		UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOver");
	}





}// end
