using UnityEngine;

public class SpawnObject : CustomCode
{
    [SerializeField] private GameObject objectToSpawn;

    [SerializeField] private Vector2 spawnVecter;

    protected override void Codes()
    {
        Instantiate(objectToSpawn, spawnVecter, Quaternion.identity);
    }
}
