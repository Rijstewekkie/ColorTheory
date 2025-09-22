using UnityEditor;
using UnityEngine;

public class Lightning : CustomCode
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    public Sprite CloudSpriteColored;

    protected override void Codes()
    {
        spriteRenderer.sprite = CloudSpriteColored;
    }
}
