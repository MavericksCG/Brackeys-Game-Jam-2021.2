using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

	public int score;

	public Text scoreText;

	private void Update() {
		scoreText.text = score.ToString();
	}

	private void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Obstacle")) {

			score++;
		}

		if (score >= 250f) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
