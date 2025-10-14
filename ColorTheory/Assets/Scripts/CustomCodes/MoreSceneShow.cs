using UnityEngine;

public class MoreSceneShow : CustomCode
{
    [SerializeField] private GameObject[] moreScene;

    protected override void Codes()
    {
        for (int i = 0; i < moreScene.Length; i++)
        {
            moreScene[i].SetActive(true);
        }
    }
}
