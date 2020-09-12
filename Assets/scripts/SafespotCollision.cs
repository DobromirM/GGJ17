using UnityEngine;
// Conditions for Hunter interacting with Safespot
public class SafespotCollision : MonoBehaviour
{
    private GameObject[] pigMen;

    void Start()
    {
        //startingPos = this.transform.position;
        pigMen = GameObject.FindGameObjectsWithTag("hunter");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Collider>().CompareTag("Player"))

            foreach (GameObject hunter in pigMen)
            {
                hunter.GetComponent<chase>().Respawn();
            }
    }
}
