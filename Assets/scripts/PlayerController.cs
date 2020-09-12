using UnityEngine;


public class PlayerController : MonoBehaviour
{

    public float speed = 6.0F;
    public float gravity = 20.0F;
    public AudioClip shoot;
    public float volume;
    public GameObject moveSound;
    public GameObject idleSound;

    public GameObject bullet;
    public Animator animator;

    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;

    void Start()
    {
        // Store reference to attached component
        AudioListener.volume = volume;
        controller = GetComponent<CharacterController>();
        this.gameObject.AddComponent<AudioSource>();
    }

    void Update()
    {
        animator.SetFloat("horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("vertical", Input.GetAxis("Vertical"));

        // Character is on ground (built-in functionality of Character Controller)
        if (controller.isGrounded)
        {
            // Use input up and down for direction, multiplied by speed
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Debug.Log(moveDirection);
            if (moveDirection.x != 0 || moveDirection.z != 0)
            {
                //Debug.Log(moveSound);
                moveSound.SetActive(true);
                idleSound.SetActive(false);
            }

            if (moveDirection.x == 0 && moveDirection.z == 0)
            {
                //Debug.Log(moveSound);
                moveSound.SetActive(false);
                idleSound.SetActive(true);
            }


            //moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;
        }
        // Apply gravity manually.
        moveDirection.y -= gravity * Time.deltaTime;
        // Move Character Controller
        controller.Move(moveDirection * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            // Quaternion.identity = add the bullet with no rotation


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name == "shoot")
                {
                    Instantiate(bullet, transform.position, Quaternion.Inverse(transform.rotation));
                    AudioListener.volume = 0.2f;
                    this.GetComponent<AudioSource>().clip = shoot;
                    this.GetComponent<AudioSource>().Play();
                }

            }

        }


    }
}
