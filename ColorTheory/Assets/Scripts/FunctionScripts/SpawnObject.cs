using UnityEngine;

public class SpawnObject : CustomCode
{
    [SerializeField] private GameObject objectToSpawn;

    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedY;
    private Vector2 spawnVector;

    private void Start()
    {
        spawnVector = new Vector2(SpeedX, SpeedY);
    }

    protected override void Codes()
    {
        Debug.Log("sppawwnn");
        Instantiate(objectToSpawn, spawnVector, Quaternion.identity);
    }
}
