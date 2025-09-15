using UnityEngine;

public class SplitSailsOnSpace : MonoBehaviour
{
    public GameObject sail1;
    public GameObject sail2;

    public GameObject Ball;

    public bool SailsMoving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SailsMoving = true;
        }

        Debug.Log(sail1.transform.position.x);

        if (SailsMoving)
        {
            sail1.transform.position += new Vector3(0.005f, 0, 0);
            sail2.transform.position += new Vector3(-0.005f, 0, 0);
            if (sail1.transform.position.x > 0f)
            {
                SailsMoving = false;
                Ball.GetComponent<Ball>().Drop();
            }
        }
    }
}
