using System;
using TMPro;
using UnityEngine;
using static SceneAnimationManager;

public abstract class Next : MonoBehaviour, OnNext
{
    public Animator[] animators;
    //protected TextMeshProUGUI[] TMP;

    //protected float[] showTMPTime;

    public bool done = false;
    //public event Action Completed;


    protected abstract void NextAnimation();
    //protected abstract void NextText();

    public void NextThings()
    {
        NextAnimation();
        //NextText();

    }


}
