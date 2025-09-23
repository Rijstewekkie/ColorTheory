using UnityEngine;

public class HideCan : MonoBehaviour
{
    [SerializeField] private GameObject[] bucketObject;

    public void hideObject()
    {
        for (int i = 0; i < bucketObject.Length; i++)
        {
            bucketObject[i].SetActive(false);
            Destroy(bucketObject[i]);
        }

    }
}
