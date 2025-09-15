using UnityEngine;

public class HideCan : MonoBehaviour
{
    public void hideObject()
    {
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
