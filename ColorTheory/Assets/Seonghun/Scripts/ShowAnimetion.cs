using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnimetion : Next
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
        animator.SetTrigger("Start1");
        yield return new WaitForSeconds(animator.GetAnimatorTransitionInfo(1).normalizedTime);
        done = true;
    }

}
