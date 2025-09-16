using UnityEngine;

public class SplitSailsOnSpace : MonoBehaviour
{
    public GameObject sail1;
    public GameObject sail2;
    public GameObject sail3;

    public Sprite Sail1Closed;
    public Sprite Sail2Closed;
    public Sprite Sail3Closed;

    public Sprite Sail1Open;
    public Sprite Sail2Open;
    public Sprite Sail3Open;


    public GameObject Ball;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OpenSails();
        }
    }

    void OpenSails()
    {
        sail1.GetComponent<SpriteRenderer>().sprite = Sail1Open;
        sail2.GetComponent<SpriteRenderer>().sprite = Sail2Open;
        sail3.GetComponent<SpriteRenderer>().sprite = Sail3Open;

        Ball.GetComponent<Ball>().Drop();
    }
}
