using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnimetion : Next
{
    [SerializeField] private string tirggerName;

    public Animator[] animators;

    protected override void NextAnimation()
    {
        foreach (var anime in animators)
        {
            StartCoroutine(Animation(anime));
        }
    }

    private IEnumerator Animation(Animator animator)
    {
        animator.SetTrigger(tirggerName);
        yield return new WaitForSeconds(animator.GetAnimatorTransitionInfo(0).normalizedTime);
        done = true;
    }

}
