using System;
using TMPro;
using UnityEngine;
using static SceneAnimationManager;

public abstract class Next : MonoBehaviour, OnNext
{
    public bool done = false;


    protected virtual void NextAnimation()
    {

    }

    protected virtual void NextSprite()
    {

    }

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
