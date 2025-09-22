using UnityEngine;

public class Scene2Ball : CustomCode
{
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    protected override void Codes()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
    }
}
