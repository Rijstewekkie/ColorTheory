using System;
using TMPro;
using UnityEngine;
using static SceneAnimationManager;

// You can inherit the 'Next' code in the child script and implement it using override
public abstract class Next : MonoBehaviour, OnNext
{
    public bool done = false;

    // If you want to add animation, use this code
    protected virtual void NextAnimation()
    {

    }

    // If you want to change the sprite, use this code
    protected virtual void NextSprite()
    {

    }

    // If you want to add code, Inherit 'Custom Code' and implement it as 'Codes'
    protected virtual void NextCode()
    {

    }

    public void NextThings()
    {
        NextAnimation();
        NextSprite();
        NextCode();
    }


}
