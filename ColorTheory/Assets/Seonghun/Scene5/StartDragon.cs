using System.Collections;
using UnityEngine;

public class StartDragon : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start()
    {
        StartCoroutine(StartAnimation());
    }


    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("Start5");
    }
}
