using UnityEngine;

public class chase : MonoBehaviour
{
    public float speed = 2f;
    public AudioClip spot;
    public AudioClip die;
    public Animator animator;

    private Vector3 startingPos;
    private Transform target = null;
    private GameObject player;
    private bool seen = false;
    private Vector3 delta;

    private bool CanSeeEnemy()
    {
        Vector3 here = transform.position;
        // if enemy not destroyed yet, and is in front the camera...
        if (player && player.GetComponent<Renderer>().isVisible)
        {
            // do a Linecast:
            Vector3 pos = player.transform.position;
            RaycastHit hit;

            // if nothing is obscuring the enemy...
            if (Physics.Linecast(here, pos, out hit) && hit.transform == player.transform)
            {
                // finish function and return its GameObject reference:
                return true;
            }
        }
        return false; // if none at sight, return null
    }
    // Use this for initialization
    void Start()
    {
        startingPos = this.transform.position;
        target = GameObject.FindGameObjectWithTag("Player").transform;
        player = GameObject.FindGameObjectsWithTag("Player")[0];
        this.gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (CanSeeEnemy())
        {
      
            if (!seen)
            {
                AudioListener.volume = 0.1f;
                this.GetComponent<AudioSource>().clip = spot;
                this.GetComponent<AudioSource>().Play();
                seen = true;
            }
            delta = transform.position - target.position;


            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            animator.SetFloat("horizontal", delta.x);
            animator.SetFloat("vertical", delta.z);


        }
    }

    public void Respawn()
    {
        seen = false;
        AudioListener.volume = 0.1f;
        this.GetComponent<AudioSource>().clip = die;
        this.GetComponent<AudioSource>().Play();
        transform.position = startingPos;
    }
}
