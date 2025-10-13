using UnityEngine;

public class OpenSail : CustomCode
{
    [SerializeField] private SpriteRenderer[] nowSail;
    [SerializeField] private Collider2D[] nowCollider;
    [SerializeField] private Collider2D[] changeCollider;
    [SerializeField] private Sprite openSail;
    [Space(10)]
    [SerializeField] private GameObject yellowCan;
    [SerializeField] private GameObject shark;
    [SerializeField] private GameObject pirate;



    protected override void Codes()
    {
        for(int i = 0; i < nowSail.Length; i++)
        {
            nowSail[i].sprite = openSail;
            nowCollider[i].enabled = false;
            changeCollider[i].enabled = true;
        }
        yellowCan.SetActive(true);
        shark.SetActive(true);
        pirate.SetActive(true);
    }
}
