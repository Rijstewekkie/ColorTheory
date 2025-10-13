using System.Collections;
using UnityEngine;

public class ShowScene4 : CustomCode
{
    [SerializeField] private GameObject scene4;

    protected override void Codes()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1f);
        scene4.SetActive(true);
    }
}
