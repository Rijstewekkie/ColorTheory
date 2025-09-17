using UnityEngine;

public class WaveMover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       GetComponent<MeshRenderer>().material.mainTextureOffset += new Vector2(-0.3f, 0) * Time.deltaTime;
        GetComponent<Transform>().localScale = new Vector3(20, Mathf.PingPong(Time.time * 0.5f, 1f) + 4f, 1);
    }
}
