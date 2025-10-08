using UnityEngine;

public class SpawnObject : CustomCode
{
    [SerializeField] private GameObject objectToSpawn;

    [SerializeField] private float SpeedX;
    [SerializeField] private float SpeedY;
    [SerializeField] private bool SpawnOnThisObjectPos = true;

    [SerializeField] private Quaternion Rotation;

    [SerializeField] private float Xcoordinate;
    [SerializeField] private float Ycoordinate;
    private Vector2 spawnVector;

    private void Start()
    {
        spawnVector = new Vector2(SpeedX, SpeedY);
    }

    protected override void Codes()
    {
        Debug.Log("sppawwnn");
        if (SpawnOnThisObjectPos)
        {
            spawnVector = this.transform.position;
        }
        else
        {
            spawnVector = new Vector2(Xcoordinate, Ycoordinate);
        }
        Instantiate(objectToSpawn, spawnVector, Rotation);
    }
}
