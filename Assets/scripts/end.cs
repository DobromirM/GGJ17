using UnityEngine;

public class end : MonoBehaviour
{

    public GameObject sp1;
    public GameObject sp2;
    public GameObject sp3;
    public GameObject sp4;
    public GameObject sp5;
    public GameObject cage1;
    public GameObject cage2;
    public GameObject cage3;
    public GameObject cage4;
    public GameObject cage5;
    public static int counter = 0;
    public AudioClip free;

    // Use this for initialization
    void Start()
    {
        this.gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(counter);
    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject == sp1)
        {
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().Checkpoint(collision.gameObject.transform.position);
        }
        if (collision.gameObject == sp2)
        {
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().Checkpoint(collision.gameObject.transform.position);
        }
        if (collision.gameObject == sp3)
        {
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().Checkpoint(collision.gameObject.transform.position);
        }
        if (collision.gameObject == sp4)
        {
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().Checkpoint(collision.gameObject.transform.position);
        }
        if (collision.gameObject == sp5)
        {
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().Checkpoint(collision.gameObject.transform.position);
        }


        if (collision.gameObject == cage1)
        {
            counter++;
            cage1.SetActive(false);
            
            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().RescueBat();
            AudioListener.volume = 0.2f;
            this.GetComponent<AudioSource>().clip = free;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject == cage2)
        {
            counter++;
            cage2.SetActive(false);

            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().RescueBat();
            AudioListener.volume = 0.2f;
            this.GetComponent<AudioSource>().clip = free;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject == cage3)
        {
            counter++;
            cage3.SetActive(false);

            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().RescueBat();
            AudioListener.volume = 0.2f;
            this.GetComponent<AudioSource>().clip = free;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject == cage4)
        {
            counter++;
            cage4.SetActive(false);

            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().RescueBat();
            AudioListener.volume = 0.2f;
            this.GetComponent<AudioSource>().clip = free;
            this.GetComponent<AudioSource>().Play();
        }
        if (collision.gameObject == cage5)
        {
            counter++;
            cage5.SetActive(false);

            GameObject.FindGameObjectWithTag("Logic").GetComponent<GameLogic>().RescueBat();
            AudioListener.volume = 0.2f;
            this.GetComponent<AudioSource>().clip = free;
            this.GetComponent<AudioSource>().Play();
        }

        //text.guiText=counter;
    }
}