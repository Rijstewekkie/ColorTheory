using UnityEngine;

public class CanSpawnerSea : MonoBehaviour
{

    public GameObject canPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Instantiate(canPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            GameObject.FindGameObjectWithTag("BlueCan").GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-2f, 10f);
        }
    }
}
