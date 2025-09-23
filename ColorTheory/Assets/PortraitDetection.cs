using UnityEngine;

public class PortraitDetection : MonoBehaviour
{
    public GameObject AntiPortraitMessage;


    void Update()
    {
        if (Screen.height > Screen.width) // Portrait
        {
            if (!AntiPortraitMessage.activeSelf)
                AntiPortraitMessage.SetActive(true);
        }
        else // Landscape
        {
            if (AntiPortraitMessage.activeSelf)
                AntiPortraitMessage.SetActive(false);
        }
    }
}
