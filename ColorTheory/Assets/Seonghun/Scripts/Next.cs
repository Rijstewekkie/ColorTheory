using System;
using TMPro;
using UnityEngine;
using static SceneAnimationManager;

public abstract class Next : MonoBehaviour, OnNext
{
    public Animator[] animators;

    public bool done = false;


    protected abstract void NextAnimation();

    public void NextThings()
    {
        NextAnimation();

    }


}
