using UnityEngine;

public class ChangeSprite : Next
{
    [SerializeField] private SpriteRenderer nowSprite;
    [SerializeField] private Sprite changeSprite;


    // Put the Spriterenderer you want to change into 'nowSprite' and the sprite you want to change into 'changeSprite'
    protected override void NextSprite()
    {
        nowSprite.sprite = changeSprite;
        done = true;
    }

}
