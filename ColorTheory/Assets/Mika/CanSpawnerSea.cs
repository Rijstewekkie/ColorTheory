using UnityEngine;

public class CanSpawnerSea : MonoBehaviour
{

    public GameObject canPrefab;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Collision " + collision.name);
        if (collision.CompareTag("Ball"))
        {
            //Debug.Log("CanPrefab " + canPrefab.name);
            GameObject bucket = Instantiate(canPrefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);

            //Debug.Log("Bucket " + bucket.name);
            bucket.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-2f, 10f);

            Destroy(collision.gameObject);
        }
    }
}
