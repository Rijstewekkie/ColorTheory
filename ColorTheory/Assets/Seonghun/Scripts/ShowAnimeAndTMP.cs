using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnimeAndTMP : Next
{   
    protected override void NextAnimation()
    {
        foreach (var anime in animators)
        {
            StartCoroutine(Animation(anime));
        }
    }

    private IEnumerator Animation(Animator animator)
    {
        //animator.SetTrigger();
        animator.SetTrigger("Start1");
        yield return new WaitForSeconds(animator.GetAnimatorTransitionInfo(1).normalizedTime);
        done = true;
        //Completed?.Invoke();
    }

    //protected override void NextText()
    //{
    //    foreach (var texts in TMP)
    //    {
            
    //    }
    //}


}
