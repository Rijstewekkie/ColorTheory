using UnityEngine;

public class FallingBlock : MonoBehaviour
{
    public bool Falling = false;

    [SerializeField] Rigidbody2D RB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        if (Falling)
        {
            RB.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
