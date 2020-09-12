using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller: MonoBehaviour {

	public void loadScene(int index) {
		SceneManager.LoadScene (index);
	}
	public void exitGame() {
		Application.Quit ();
	}
}
