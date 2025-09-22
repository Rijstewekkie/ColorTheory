using UnityEditor;
using UnityEngine;

public class Lightning : CustomCode
{
    //public GameObject LightningBolt;

    [SerializeField] private SpriteRenderer spriteRenderer;

    //public Sprite CloudSpriteUncolored;
    //public Sprite LightningspriteUncolored;

    public Sprite CloudSpriteColored;

    protected override void Codes()
    {
        spriteRenderer.sprite = CloudSpriteColored;
    }
}
