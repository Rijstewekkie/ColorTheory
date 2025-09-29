using System.Collections;
using UnityEngine;

public class SharkSpawner : MonoBehaviour
{
    [SerializeField] private GameObject sharkPrefab;
    public void SpawnShark()
    {
        StartCoroutine(SharkMovement());
    }

    IEnumerator SharkMovement()
    {
        Rigidbody2D rb = GameObject.Find("Shark").GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.angularVelocity = 0;
        transform.rotation = Quaternion.Euler(0, 0, 0);
        yield return new WaitForSeconds(1);
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.position = new Vector2(10f, 0);
        rb.gravityScale = -0;
        rb.linearVelocity = new Vector2(-5, 0);
        yield return new WaitForSeconds(.5f);
        rb.linearVelocity = new Vector2(0, 0);
        rb.angularVelocity = 0;
    }
}
