using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour {
	void OnTriggerEnter2D() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	void Update() {
		if (Input.GetKey("r")) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
		else if (Input.GetKey("1")) {
			SceneManager.LoadScene(0);
		}
		else if (Input.GetKey("2")) {
			SceneManager.LoadScene(1);
		}
	}
}