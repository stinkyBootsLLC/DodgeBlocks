using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour 
{
	// will pick an index from the array and spawn transforms
	// in the other spots it does NOT pick

	public Transform[] spawnPoints;
	public GameObject blockPrefab;

	public float timeBetweenWaves = 5f;

	// stores the time for the next time to spawn a block
	private float timeToSpawn = 2.0f;

	void Update () 
	{
		// SpawnBlocks ();
		// by doing this alone for every frame  its too many blocks
		// have to keep track of time and slow it down 

		// amount of seconds that have pass since the game started

		if (Time.time >= timeToSpawn)
		{
			SpawnBlocks ();

			// resetting timeToSpawn
			// timeBetween waves = delay before next spawn wave
			timeToSpawn = Time.time + timeBetweenWaves;
		}



	}

	void SpawnBlocks ()
	{
		// temp variable
		// amount of spawn points in the list .lenth
		int randomIndex = Random.Range(0, spawnPoints.Length); // min and max



		// this will count up until the end of the list
		for (int i = 0; i < spawnPoints.Length; i++)
		{
			
			if(randomIndex == i)
			{
				// do nothing
				// going to spawn the rest of the index 
			}
			if(randomIndex != i)
			{
				// Instantiate () is a monobehaviour public function
				// get the index of random i position
				// Quaternion.identity = DONT rotate
				Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity); 
			}
		}
	}

} // end class
