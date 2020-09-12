using UnityEngine;
// Conditions for Player interacting with Hunter

public class HunterCollision : MonoBehaviour
{
    public AudioClip die;
    private Vector3 startingPos;
    // Use this for initialization
    void Start()
    {
        startingPos = this.transform.parent.transform.position;
        this.gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("hunter"))
        {// Player touches Hunter
            other.transform.GetChild(0).gameObject.SetActive(false);
            Respawn();
        }
    }

    void Respawn()
    {
        AudioListener.volume = 0.2f;
        this.GetComponent<AudioSource>().clip = die;
        this.GetComponent<AudioSource>().Play();
        GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().LoseLife();
        this.transform.parent.transform.position = startingPos;
    }

    public void UpdateStartPos(Vector3 position)
    {
        this.startingPos = position;
    }
}
