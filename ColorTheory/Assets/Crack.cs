using UnityEngine;

public class Crack : MonoBehaviour
{
    public GameObject BackOfBoat;
    public GameObject FrontOfBoat;
    public GameObject MiddleOfBoat;

    public Sprite BrokenFrontSprite;
    public Sprite BrokenBackSprite;

    public GameObject Cloud;

    void Start()
    {
        BackOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        FrontOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        MiddleOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;
        MiddleOfBoat.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Cloud.GetComponent<Lightning>().LightningStruck == true)
        {
            BreakBoat();
        }
    }

    public void BreakBoat()
    {
        BackOfBoat.GetComponent<SpriteRenderer>().sprite = BrokenBackSprite;
        BackOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        BackOfBoat.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -1f);
        FrontOfBoat.GetComponent<SpriteRenderer>().sprite = BrokenFrontSprite;
        FrontOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        FrontOfBoat.GetComponent<Rigidbody2D>().linearVelocity = new Vector2(0, -1f);
        MiddleOfBoat.GetComponent<Rigidbody2D>().gravityScale = 2;
        MiddleOfBoat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
    }
}
