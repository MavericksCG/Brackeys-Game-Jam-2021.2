using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	// Variables
	public int damage = 1;
	public float speed;

	public GameObject effect;
	public GameObject explosionSound;

	public Animator camAnim;



	// Methods
	private void Start() {
		camAnim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();
	}


	private void Update() {
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}


	 void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player")) {

			camAnim.SetTrigger("shake");

			Instantiate(effect, transform.position, Quaternion.identity);
			Instantiate(explosionSound, transform.position, Quaternion.identity);


			other.GetComponent<Player>().health -= damage;			
			Destroy(gameObject);
		}

		
	}
}
