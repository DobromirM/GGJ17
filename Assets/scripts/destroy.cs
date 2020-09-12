using UnityEngine;


public class destroy : MonoBehaviour
{

    public static bool flag = true;

    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }



    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "wall" || collision.gameObject.tag == "hunter")
        {
            if (collision.gameObject.transform.childCount > 0)
            {
                collision.gameObject.transform.GetChild(0).gameObject.SetActive(false);
                collision.gameObject.transform.gameObject.GetComponent<show>().reset = 100;
            }


            Destroy(gameObject);
        }

    }
}
