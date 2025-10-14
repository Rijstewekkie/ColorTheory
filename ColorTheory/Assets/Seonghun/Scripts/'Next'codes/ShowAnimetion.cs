using System.Collections;
using UnityEngine;

public class ShowAnimetion : Next
{
    public string tirggerName;

    public Animator[] animators;

    public override void NextAnimation()
    {
        Debug.Log("Animation Start");
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
