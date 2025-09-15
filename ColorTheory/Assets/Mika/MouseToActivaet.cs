using UnityEngine;

public class MouseToActivaet : MonoBehaviour
{


    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }   
    }
}
