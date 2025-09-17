using UnityEngine;

public class Shark : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            rb.linearVelocity = new Vector2(-10, 10);
            rb.gravityScale = 2;
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
