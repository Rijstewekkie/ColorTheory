using UnityEngine;

public class OpenSail : CustomCode
{
    [SerializeField] private SpriteRenderer[] nowSail;
    [SerializeField] private Sprite openSail;


    protected override void Codes()
    {
        for(int i = 0; i < nowSail.Length; i++)
        {
            nowSail[i].sprite = openSail;
        }

    }
}
