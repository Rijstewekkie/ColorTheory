using UnityEngine;

public class HideCan : MonoBehaviour
{
    [SerializeField] private GameObject[] bucketObject;
    public void hideObject()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
