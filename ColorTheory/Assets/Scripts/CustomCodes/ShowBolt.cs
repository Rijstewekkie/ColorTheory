using UnityEngine;

public class ShowBolt : CustomCode
{
    [SerializeField] private GameObject bolt;
    [SerializeField] private GameObject boltFlash;

    protected override void Codes()
    {
        bolt.SetActive(true);
        boltFlash.SetActive(true);
    }
}
