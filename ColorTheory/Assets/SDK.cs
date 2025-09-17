using UnityEngine;

public class SDK : MonoBehaviour
{
    private bool hasStarted = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PokiUnitySDK.Instance.gameplayStart();
                hasStarted = true;
            }

        }
    }
}
