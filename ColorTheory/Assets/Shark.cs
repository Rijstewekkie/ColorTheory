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
        if (other.gameObject.CompareTag("Pirate"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.name == "SharkTrigger")
        {
            sharkSpawner.GetComponent<SharkSpawner>().SpawnShark();
        }
    }
}
