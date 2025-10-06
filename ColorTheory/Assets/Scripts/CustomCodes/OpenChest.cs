using System.Collections;
using UnityEngine;

public class OpenChest : CustomCode
{
    [SerializeField] private GameObject closed;
    [SerializeField] private GameObject open;
    [SerializeField] private Animator animator;

    protected override void Codes()
    {
        closed.SetActive(false);
        open.SetActive(true);
        StartCoroutine(lateStart());
    }

    private IEnumerator lateStart()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("TakeABall");
    }
}
