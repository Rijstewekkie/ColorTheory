using System.Collections;
using UnityEngine;

public class DropAfterBeingTouched : MonoBehaviour
{
    public string TagOfTouchingObject;
    public Rigidbody2D rb;
    public float delayBeforeDrop = 0f;
    void Start()
    {
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    IEnumerator Drop()
    {
        yield return new WaitForSeconds(delayBeforeDrop);
        rb.bodyType = RigidbodyType2D.Dynamic;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(TagOfTouchingObject))
        {
            StartCoroutine(Drop());
        }
    }


}
