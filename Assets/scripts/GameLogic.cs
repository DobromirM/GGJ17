using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour {

    private GameObject player;
    public int bats;
    public int lives;
    public Text ui_lives;
    public Text ui_bats;

    // Use this for initialization
    void Start () {
        this.player = GameObject.FindGameObjectWithTag("Player");
        bats = 5;
        lives = 3;

        ui_lives.text = "Lives: " + lives;
        ui_bats.text = "Bats: " + bats;
    }
	
    public void LoseLife()
    {
        lives--;
        ui_lives.text = "Lives: " + lives;
    }

    public void RescueBat()
    {
        bats--;
        ui_bats.text = "Bats: " + bats;
    }

    public void Checkpoint(Vector3 position)
    {
        this.player.transform.GetChild(2).GetComponent<HunterCollision>().UpdateStartPos(position);
    }

	// Update is called once per frame
	void Update ()
    {
		if(lives<=0)
        {
            LoseGame();
        }
        if(bats<=0)
        {
            WinGame();
        }
	}

    public void WinGame() {
        SceneManager.LoadScene(3);
    }

    public void LoseGame() {
        SceneManager.LoadScene(2);
    }
}
