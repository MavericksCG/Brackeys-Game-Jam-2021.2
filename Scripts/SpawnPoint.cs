using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
	// Variable
	public GameObject obstacle;


	// Start Method
	void Start() {
		Instantiate(obstacle, transform.position, Quaternion.identity);
	}
}
