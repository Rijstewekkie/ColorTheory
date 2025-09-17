using UnityEngine;

public class WaveTeleporter : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wave"))
        {
            Debug.Log("Wave Teleported");
            collision.GetComponent<Transform>().position = new Vector3(0, 0, 0);
        }
    }
}
