using UnityEngine;

public class ChangeFadeColor : CustomCode
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    protected override void Codes()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 0f);
    }
}
