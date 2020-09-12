using UnityEngine;

public class bullet : MonoBehaviour
{
    public int speed = 6;
    private Vector3 target;

    // Function called once when the bullet is created
    void Start()
    {
        // Get the rigidbody component
        var r2d = GetComponent<Rigidbody>();
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target = target - r2d.position;
        target.y = 0;
        r2d.velocity = target * speed;
    }
}
