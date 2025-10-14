using System.Collections;
using UnityEngine;

public class ShowPortal : CustomCode
{
    [SerializeField] private GameObject portal;

    protected override void Codes()
    {
        StartCoroutine(FadeTime());
    }

    private IEnumerator FadeTime()
    {
        yield return new WaitForSeconds(5f);
        portal.SetActive(true);
    }
}
