using UnityEngine;

public class ShowScene4 : CustomCode
{
    [SerializeField] private GameObject[] scene4 = new GameObject[2];

    protected override void Codes()
    {
        scene4[0].SetActive(true);
        scene4[1].SetActive(true);
    }
}
