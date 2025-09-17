using UnityEditor;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public GameObject LightningBolt;

    public Sprite CloudSpriteUncolored;
    public Sprite LightningspriteUncolored;

    public Sprite CloudSpriteColored;

    public bool LightningStruck = false;


    private void Start()
    {
        LightningBolt.GetComponent<SpriteRenderer>().sprite = LightningspriteUncolored;
        GetComponent<SpriteRenderer>().sprite = CloudSpriteUncolored;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Strike();
        }
    }

    public void Strike()
    {
        LightningBolt.GetComponent<SpriteRenderer>().color = Color.yellow;
        GetComponent<SpriteRenderer>().sprite = CloudSpriteColored;
        LightningStruck = true;
    }
}
