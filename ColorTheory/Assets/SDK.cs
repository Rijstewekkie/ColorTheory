using UnityEngine;

public class SDK : MonoBehaviour
{
    private bool hasStarted = false;

    [SerializeField] private GameObject AntiPortrait;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AntiPortrait.SetActive(true);
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
