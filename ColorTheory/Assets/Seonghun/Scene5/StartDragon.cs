using System.Collections;
using UnityEngine;

public class StartDragon : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject dragon1;
    [SerializeField] private GameObject dragon2;

    void Start()
    {
        StartCoroutine(StartAnimation());
    }


    private IEnumerator StartAnimation()
    {
        yield return new WaitForSeconds(1f);
        animator.SetTrigger("Start5");
        yield return new WaitForSeconds(3.5f);
        dragon1.SetActive(true);
        dragon2.SetActive(true);
    }
}
