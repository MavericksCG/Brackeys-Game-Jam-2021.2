using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	// Variables
	private Vector2 targetPos;

	public float Yincrement;

	public float speed;
	public float maxHeight;
	public float minHeight;

	public int health = 3;

	public GameObject effect;
	public GameObject gameOver;
	public GameObject playerHopSound;
	public GameObject gameMusic;
	public GameObject scoreText;

	public Animator camAnim;

	public Text healthDisplay;




	// Methods

	public void Awake() {
		Instantiate(gameMusic);
	}

	private void Update() {

		healthDisplay.text = health.ToString();

		if (health <= 0) {
			scoreText.SetActive(false);
			gameOver.SetActive(true);
			Destroy(gameObject);
		}

		transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);



		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
			camAnim.SetTrigger("shake");
			targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);

			Instantiate(effect, transform.position, Quaternion.identity);
			Instantiate(playerHopSound, transform.position, Quaternion.identity);




		}	else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
			camAnim.SetTrigger("shake");
			targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);

			Instantiate(effect, transform.position, Quaternion.identity);
			Instantiate(playerHopSound, transform.position, Quaternion.identity);
		}
	}
}
