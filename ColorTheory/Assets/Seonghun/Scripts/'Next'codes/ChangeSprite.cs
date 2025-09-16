using UnityEngine;

public class ChangeSprite : Next
{
    [SerializeField] private SpriteRenderer nowSprite;
    [SerializeField] private Sprite changeSprite;


    
    protected override void NextSprite()
    {
        nowSprite.sprite = changeSprite;
        done = true;
    }

}
