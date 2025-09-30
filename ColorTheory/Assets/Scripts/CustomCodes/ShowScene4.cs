using System.Collections;
using UnityEngine;

public class ShowScene4 : CustomCode
{
    [SerializeField] private GameObject[] scene4 = new GameObject[3];

    protected override void Codes()
    {
        StartCoroutine(ChangeScene());
    }

    private IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1f);
        scene4[0].SetActive(true);
        scene4[1].SetActive(true);
        scene4[2].SetActive(false);
    }
}
