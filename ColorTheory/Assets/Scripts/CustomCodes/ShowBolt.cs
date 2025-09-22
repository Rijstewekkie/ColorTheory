using UnityEngine;

public class ShowBolt : CustomCode
{
    [SerializeField] private GameObject bolt;

    protected override void Codes()
    {
        bolt.SetActive(true);
    }
}
