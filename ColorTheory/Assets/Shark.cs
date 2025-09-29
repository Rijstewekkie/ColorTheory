using System.Collections;
using UnityEngine;

public class Shark : CustomCode
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject sharkSpawner;


    private void Start()
    {
        sharkSpawner = GameObject.Find("SharkSpawner");
    }
    protected override void Codes()
    {
                rb.linearVelocity = new Vector2(-10, 10);
                rb.gravityScale = 2;
    }
        
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Pirate")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "SharkTrigger")
        {
            sharkSpawner.GetComponent<SharkSpawner>().SpawnShark();
        }
    }

    IEnumerator MoveBackOnScreen()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
        rb.angularVelocity = 0;
        transform.rotation = Quaternion.Euler(0, 0, -32f);
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
