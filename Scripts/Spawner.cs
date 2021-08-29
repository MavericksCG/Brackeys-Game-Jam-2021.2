using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

	// Variables
	public GameObject[] obstaclePatterns;
	public float timeBetweenSpawn;
	public float startTimeBetweenSpawn;
	public float decreaseTime;
	public float minTime = 0.65f;


	// Methods
	private void Update() {

		if (timeBetweenSpawn <= 0) {

			int rand = Random.Range(0, obstaclePatterns.Length);

			Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
			timeBetweenSpawn = startTimeBetweenSpawn;
			
			if (startTimeBetweenSpawn > minTime) {
				startTimeBetweenSpawn -= decreaseTime;
			}
		}
		else {
			timeBetweenSpawn -= Time.deltaTime;
		}
	}
}
