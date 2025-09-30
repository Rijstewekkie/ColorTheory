using UnityEngine;

public class OpenChest : CustomCode
{
    [SerializeField] private GameObject closed;
    [SerializeField] private GameObject open;

    protected override void Codes()
    {
        closed.SetActive(false);
        open.SetActive(true);
    }
}
