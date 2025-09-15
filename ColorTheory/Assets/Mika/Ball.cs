using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb;

    void Start()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FallingBlock"))
        {
            collision.gameObject.GetComponent<FallingBlock>().Fall();
        }
    }

    public void Drop()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
