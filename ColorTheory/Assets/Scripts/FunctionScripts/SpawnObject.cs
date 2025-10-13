using UnityEngine;

public class SpawnObject : CustomCode
{
    [SerializeField] private GameObject objectToSpawn;

    [SerializeField] private float Xcoordinate;
    [SerializeField] private float Ycoordinate;
    [SerializeField] private bool SpawnOnThisObjectPos = true;
    private Vector2 spawnVector;

    private bool hasSpawned = false;

    private void Start()
    {
    }

    protected override void Codes()
    {
        if (hasSpawned) return;
        Debug.Log("sppawwnn");
        if (SpawnOnThisObjectPos)
        {
            spawnVector = this.transform.position;
        }
        else
        {
            spawnVector = new Vector2(Xcoordinate, Ycoordinate);
        }
        Instantiate(objectToSpawn, spawnVector, Quaternion.identity);

        hasSpawned = true;
    }
}
