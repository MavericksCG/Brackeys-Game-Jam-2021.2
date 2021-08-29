using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
	public float lifetime;

	private void Start() {
		Destroy(gameObject, lifetime); // Obstacle Gets Destroyed after specified lifetime
	}
}
