using UnityEngine;

public class CanSpawnerSea : MonoBehaviour
{

    public GameObject canPrefab;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Instantiate(canPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            GameObject.FindGameObjectWithTag("BlueBucket").GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-2f, 10f);
            Destroy(collision.gameObject);
        }
    }
}
